using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleDeEstoque.DataSet1TableAdapters;

namespace ControleDeEstoque
{
    public partial class frmExpedicao : Form
    {
        private int _codigoProduto;
        private int CodigoPreProdutoSelecionado
        {
            get
            {
                return Convert.ToInt32(cmbProdutos.SelectedValue);
            }
        }

        public frmExpedicao()
        {
            InitializeComponent();

            _codigoProduto = 0;

            MontarCombo();
        }

        public frmExpedicao(int CodigoProduto)
        {
            InitializeComponent();

            _codigoProduto = CodigoProduto;
            
            MontarCombo();

            cmbProdutos.SelectedValue = _codigoProduto;
        }

        private void frmExpedicao_Shown(object sender, EventArgs e)
        {
            if (grdProdutos.Rows.Count > 0)
            {
                ZerarCelulasDeQuantidade();
                grdProdutos.Rows[0].Cells[3].Selected = true;
            }

            if (_codigoProduto == 0)
            {
                cmbProdutos.Focus();
            }
            else
            {
                grdProdutos.Focus();
            }
        }

        private void MontarCombo()
        {
            try
            {
                EstoqueAuxTableAdapter taEstoque = new EstoqueAuxTableAdapter();
                taEstoque.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

                cmbProdutos.DataSource = taEstoque.ListarProdutosComEstoque().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MontarGrid();
        }

        private void MontarGrid()
        {
            EstoqueTableAdapter taEstoque = new EstoqueTableAdapter();
            taEstoque.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

            grdProdutos.AutoGenerateColumns = false;
            grdProdutos.DataSource = taEstoque.ListarLotesComEstoque(CodigoPreProdutoSelecionado);

            if (grdProdutos.Rows.Count > 0)
            {
                grdProdutos.Rows[0].Cells[3].Selected = true;
                grdProdutos.Focus();
                ZerarCelulasDeQuantidade();
            }
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            this.Close();
        }

        private bool Salvar()
        {
            PB.ProgressBar pb = new PB.ProgressBar();
            
            pb.MaxValue = (grdProdutos.Rows.Count * 3);
            pb.Show();

            // Efetua todas as consistências
            foreach (DataGridViewRow row in grdProdutos.Rows)
            {
                pb.Incrementar(1);
                if (Convert.ToInt32(row.Cells["Quantidade"].Value) > Convert.ToInt32(row.Cells["Estoque"].Value))
                {
                    pb.Close();
                    MessageBox.Show("Erro no Lote " + row.Cells["Lote"].Value.ToString() + "\n\nNão há estoque suficiente para realizar esta operação.");
                    row.Cells[3].Selected = true;
                    grdProdutos.Focus();
                    return true;
                }
            }

            try
            {
                // Salva todas as linhas
                foreach (DataGridViewRow row in grdProdutos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Quantidade"].Value) > 0)
                    {
                        ExpedicaoTableAdapter taExpedicao = new ExpedicaoTableAdapter();
                        taExpedicao.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

                        pb.Incrementar(1);
                        taExpedicao.Insert(DateTime.Now,
                            Convert.ToInt32(row.Cells["CodigoProduto"].Value),
                            Convert.ToInt32(row.Cells["Quantidade"].Value),
                            row.Cells["Lote"].Value.ToString()
                            );

                        EstoqueTableAdapter taEstoque = new EstoqueTableAdapter();
                        taEstoque.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

                        pb.Incrementar(1);
                        taEstoque.RemoverEstoque(Convert.ToInt32(row.Cells["Quantidade"].Value),
                            row.Cells["Lote"].Value.ToString(),
                            Convert.ToInt32(row.Cells["CodigoProduto"].Value)
                            );
                    }
                    else
                    {
                        pb.Incrementar(2);
                    }
                }

                pb.Close();
                MessageBox.Show("Produtos expedidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
            return false;
        }

        private void ZerarCelulasDeQuantidade()
        {
            foreach (DataGridViewRow row in grdProdutos.Rows)
            {
                row.Cells["Quantidade"].Value = "0";
            }
        }

        private void grdProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {            
            e.Handled = Util.VerificarNumerico(e.KeyChar);
        }


        private void grdProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) &&
                  (grdProdutos.CurrentCell.RowIndex == grdProdutos.Rows[grdProdutos.Rows.Count - 1].Index))
            {
                e.Handled = Salvar();
            }

        }

        private void frmExpedicao_Load(object sender, EventArgs e)
        {

        }


        
    }
}
