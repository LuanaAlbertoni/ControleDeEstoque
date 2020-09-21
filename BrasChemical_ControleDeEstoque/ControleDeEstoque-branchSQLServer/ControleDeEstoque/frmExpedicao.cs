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
    public partial class frmExpedicao : Form
    {
        private int _codigoProduto;
        EstoqueRepositorio _repositorioEstoque = new EstoqueRepositorio();

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
        private void frmExpedicao_Load(object sender, EventArgs e)
        {
            _repositorioEstoque = new EstoqueRepositorio();
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
                //Lista todos os produtos com Estoque

                ProdutosRepositorio produtosRepositorio = new ProdutosRepositorio();
                var lista = produtosRepositorio.SelectAll().OrderBy(x => x.Litros).ToList();

                cmbProdutos.DataSource = (from x in lista.OrderBy(z => z.PreProduto.Nome)
                                           select new ItemEstoque()
                                           {
                                               Id = x.Id,
                                               PreProdutoId = x.PreProdutoId,
                                               Nome = x.Nome,
                                               SomaEstoque = x.Estoque.Sum(y => y.Quantidade)
                                           }).Where(x => x.SomaEstoque > 0).ToList();
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
            grdProdutos.AutoGenerateColumns = false;

            //Lista lotes com estoque
            grdProdutos.DataSource = _repositorioEstoque.SelectAll(x => x.ProdutoId == CodigoPreProdutoSelecionado && x.Quantidade > 0).OrderBy(x => x.Lote).ToList();

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
                    Estoque estqoueAtual = (Estoque)row.DataBoundItem;
                    int quantidadeExpedida = Convert.ToInt32(row.Cells["Quantidade"].Value);

                    if (quantidadeExpedida > 0)
                    {
                        Expedicao expedicao = new Expedicao()
                        {
                            Data = DateTime.Now,
                            Quantidade = quantidadeExpedida
                        };

                        pb.Incrementar(1);
                
                        Estoque estoque = _repositorioEstoque.Find(estqoueAtual.Lote, estqoueAtual.ProdutoId);

                        estoque.Quantidade -= quantidadeExpedida;

                        estoque.Expedicao.Add(expedicao);

                        pb.Incrementar(1);
                     
                        _repositorioEstoque.Update(estoque);
                        _repositorioEstoque.Save();
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

     


        
    }
}
