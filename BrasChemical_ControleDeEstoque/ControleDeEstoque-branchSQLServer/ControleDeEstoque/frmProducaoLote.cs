using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleDeEstoque.DataSet1TableAdapters;
using ControleDeEstoque.Repositorios;
using ControleDeEstoque.Model;

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
                PreProdutosRepositorio repositorio = new PreProdutosRepositorio();

                cmbPreProduto.DataSource = repositorio.SelectAll().OrderBy(x => x.Nome).ToList();

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
            ProdutosRepositorio repositorio = new ProdutosRepositorio();
            grdProdutos.AutoGenerateColumns = false;
            grdProdutos.DataSource = repositorio.SelectAllProduziveis(CodigoPreProdutoSelecionado).OrderBy(x => x.Litros).ToList();

            if (grdProdutos.Rows.Count > 0)
            {
                grdProdutos.Rows[0].Cells[3].Selected = true;
                grdProdutos.Focus();
                ZerarCelulasDeQuantidade();
                
                txtNumeroLote.Text = TratamentoLote.getProximoLote((PreProduto)cmbPreProduto.SelectedItem);
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

                ProducaoRepositorio repositorioProducao = new ProducaoRepositorio();
                EstoqueRepositorio repositorioEstoque = new EstoqueRepositorio();

                pb.MaxValue = (grdProdutos.Rows.Count * 2) + 1;
                pb.Show();

                foreach (DataGridViewRow row in grdProdutos.Rows)
                {
                    if (!row.Cells["Quantidade"].Value.Equals("0"))
                    {
                        contMaiorZeros++;
                        pb.Incrementar(1);

                        var producao = new Producao()
                        {
                            EstoqueProdutoId = Convert.ToInt32(row.Cells["CodigoDoProduto"].Value),
                            EstoqueLote = txtNumeroLote.Text,
                            Data = Convert.ToDateTime(txtData.Text),
                            Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value)
                        };

                        pb.Incrementar(1);

                        var estoque = new Estoque()
                        {
                            ProdutoId = Convert.ToInt32(row.Cells["CodigoDoProduto"].Value),
                            Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value),
                            Lote = txtNumeroLote.Text
                        };

                        estoque.Producao.Add(producao);

                        repositorioEstoque.Add(estoque);
                        repositorioEstoque.Save();
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
