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
    public partial class frmProducaoLote : Form
    {
        
        private int _codigoProduto;
        private int CodigoPreProdutoSelecionado
        {
            get
            {
                return Convert.ToInt32(cmbPreProduto.SelectedValue);
            }
        }

        public frmProducaoLote()
        {
            InitializeComponent();

            _codigoProduto = 0;

            MontarTela();
        }

        public frmProducaoLote(int CodigoPreProduto, int CodigoProduto)
        {
            InitializeComponent();

            MontarTela();

            _codigoProduto = CodigoProduto;

            cmbPreProduto.SelectedValue = CodigoPreProduto;

        }

        private void MontarTela()
        {
            try
            {
                PreProdutosTableAdapter taPreProduto = new PreProdutosTableAdapter();
                taPreProduto.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

                cmbPreProduto.DataSource = taPreProduto.ListarPreProdutosProduziveis();

                txtData.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbPreProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MontarGrid();
        }

        private void MontarGrid()
        {
            ProdutosTableAdapter taProdutos = new ProdutosTableAdapter();
            taProdutos.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

            grdProdutos.AutoGenerateColumns = false;
            grdProdutos.DataSource = taProdutos.ListarProduziveisPorCodigoPreProduto(CodigoPreProdutoSelecionado);

            if (grdProdutos.Rows.Count > 0)
            {
                grdProdutos.Rows[0].Cells[3].Selected = true;
                grdProdutos.Focus();
                ZerarCelulasDeQuantidade();

                txtNumeroLote.Text = TratamentoLote.getProximoLote(CodigoPreProdutoSelecionado);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
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
                int contMaiorZeros = 0;
                ProducaoTableAdapter taProducao = new ProducaoTableAdapter();
                taProducao.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

                pb.MaxValue = (grdProdutos.Rows.Count * 2) + 1;
                pb.Show();

                foreach (DataGridViewRow row in grdProdutos.Rows)
                {
                    if (!row.Cells["Quantidade"].Value.Equals("0"))
                    {
                        contMaiorZeros++;
                        pb.Incrementar(1);
                        taProducao.Insert(Convert.ToDateTime(txtData.Text),
                           Convert.ToInt32(row.Cells["CodigoDoProduto"].Value),
                           Convert.ToInt32(row.Cells["Quantidade"].Value),
                           txtNumeroLote.Text);

                        pb.Incrementar(1);
                        InserirEstoque(Convert.ToInt32(row.Cells["CodigoDoProduto"].Value), Convert.ToInt32(row.Cells["Quantidade"].Value));
                    }
                    else
                    {
                        pb.Incrementar(2);
                    }

                }

                if (contMaiorZeros > 0)
                {
                    if (txtNumeroLote.Text.Equals(TratamentoLote.getProximoLote(CodigoPreProdutoSelecionado)))
                    {
                        TratamentoLote.IncrementarNumeroDeLote(CodigoPreProdutoSelecionado);
                    }
                }
                pb.Incrementar(1);

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
            taEstoque.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

            taEstoque.InserirLote(txtNumeroLote.Text, codigo, quantidade);
        }

        private void frmProducaoLote_Load(object sender, EventArgs e)
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

        private void grdProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.VerificarNumerico(e.KeyChar);
        }

        private void frmProducaoLote_Shown(object sender, EventArgs e)
        {
            if (_codigoProduto > 0)
            {
                grdProdutos.Focus();
            }
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
