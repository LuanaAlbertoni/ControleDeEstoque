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
    public partial class frmEntradaRevenda : Form
    {
        private int _codigoProduto;

        public frmEntradaRevenda()
        {
            InitializeComponent();

            _codigoProduto = 0;

            MontaTela();
        }

        public frmEntradaRevenda(int CodigoPreProduto, int CodigoProduto)
        {
            InitializeComponent();

            MontaTela();

            _codigoProduto = CodigoProduto;

            cmbPreProduto.SelectedValue = CodigoPreProduto;
        }

        private void MontaTela()
        {
            try
            {
                PreProdutosTableAdapter taPreProduto = new PreProdutosTableAdapter();

                cmbPreProduto.DataSource = taPreProduto.ListarPreProdutosComRevenda().ToList();

                txtData.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MontarGrid()
        {
            ProdutosTableAdapter taProdutos = new ProdutosTableAdapter();

            grdProdutos.AutoGenerateColumns = false;
            grdProdutos.DataSource = taProdutos.ListarRevendaPorCodigoPreProduto(Convert.ToInt32(cmbPreProduto.SelectedValue));

            if (grdProdutos.Rows.Count > 0)
            {
                grdProdutos.Rows[0].Cells[3].Selected = true;
                grdProdutos.Focus();
                ZerarCelulasDeQuantidade();
            }
        }

        private void cmbPreProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MontarGrid();

        }

        private void frmEntradaRevenda_Load(object sender, EventArgs e)
        {
            if (grdProdutos.Rows.Count > 0)
            {
                ZerarCelulasDeQuantidade();

                if (_codigoProduto > 0)
                {
                    foreach (DataGridViewRow linha in grdProdutos.Rows)
                    {
                        if (linha.Cells["CodigoDoProduto"].Value.ToString().Equals(_codigoProduto.ToString()))
                        {
                            linha.Cells[3].Selected = true;
                            grdProdutos.Focus();
                            break;
                        }
                    }
                }
                else
                {
                    grdProdutos.Rows[0].Cells[3].Selected = true;
                }
            }
        }

        private void ZerarCelulasDeQuantidade()
        {
            foreach (DataGridViewRow row in grdProdutos.Rows)
            {
                row.Cells["Quantidade"].Value = "0";
            }
        }

        private void frmEntradaRevenda_Shown(object sender, EventArgs e)
        {
            if (_codigoProduto > 0)
            {
                grdProdutos.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            this.Close();
        }

        private bool Salvar()
        {

            bool retorno = AtualizarTabelas();

            MessageBox.Show("Produtos cadastrados com sucesso");

            this.Close();

            return retorno;
        }

        private bool AtualizarTabelas()
        {
            PB.ProgressBar pb = new PB.ProgressBar();

            try
            {
                ProducaoTableAdapter taProducao = new ProducaoTableAdapter();

                foreach (DataGridViewRow row in grdProdutos.Rows)
                {
                    pb.MaxValue = (grdProdutos.Rows.Count * 2);
                    pb.Show();

                    if (row.Cells["Quantidade"].Value != null)
                    {
                        if (!row.Cells["Quantidade"].Value.Equals("0"))
                        {
                            pb.Incrementar(1);
                            taProducao.Insert(Convert.ToDateTime(txtData.Text),
                               Convert.ToInt32(row.Cells["CodigoDoProduto"].Value),
                               Convert.ToInt32(row.Cells["Quantidade"].Value),
                               "0");

                            pb.Incrementar(1);
                            InserirEstoque(Convert.ToInt32(row.Cells["CodigoDoProduto"].Value), Convert.ToInt32(row.Cells["Quantidade"].Value));
                        }
                        else
                        {
                            pb.Incrementar(2);
                        }
                    }
                }

                pb.Close();
                return true;
            }
            catch (Exception ex)
            {
                pb.Close();
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }

        private void InserirEstoque(int codigo, int quantidade)
        {
            EstoqueTableAdapter taEstoque = new EstoqueTableAdapter();

            taEstoque.InserirLote("XXX", codigo, quantidade);
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


    }
}
