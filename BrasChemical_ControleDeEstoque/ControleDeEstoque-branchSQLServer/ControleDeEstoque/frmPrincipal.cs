﻿using System;
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
    public partial class frmPrincipal : Form
    {
        EstoqueAuxTableAdapter taEstoqueAux;

        public frmPrincipal()
        {
            InitializeComponent();
            // taEstoqueAux = new EstoqueAuxTableAdapter();
            // taEstoqueAux.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MontarGrid();
            txtPesquisa.Focus();
        }


        private void MontarGrid()
        {
            //try
            //{
            //    gridProdutos.DataSource = null;
            //    gridProdutos.AutoGenerateColumns = false;

            //    ProdutosRepositorio produtosRepositorio = new ProdutosRepositorio();
            //    var lista = produtosRepositorio.SelectAll().OrderBy(x => x.Litros).ToList();

            //    gridProdutos.DataSource = (from x in lista.OrderBy(z => z.PreProduto.Nome)
            //                               select new ItemEstoque()
            //                               {
            //                                   Id = x.Id,
            //                                   PreProdutoId = x.PreProdutoId,
            //                                   Nome = x.Nome,
            //                                   SomaEstoque = x.Estoque.Sum(y => y.Quantidade)
            //                               }).ToList();

            //    foreach (DataGridViewRow linha in gridProdutos.Rows)
            //    {
            //        if (Convert.ToInt32(linha.Cells["Estoque"].Value) < 10)
            //        {
            //            linha.Cells["Estoque"].Style.ForeColor = Color.Red;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnEntradaRevenda_Click(object sender, EventArgs e)
        {
            frmEntradaRevenda frmEntradaRevenda = new frmEntradaRevenda();
            frmEntradaRevenda.ShowDialog(this);

            MontarGrid();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            frmProducaoLote frmProducaoLote = new frmProducaoLote();
            frmProducaoLote.ShowDialog(this);

            MontarGrid();
        }


        private void btnExpedicao_Click(object sender, EventArgs e)
        {
            frmExpedicao frmExpedicao = new frmExpedicao();
            frmExpedicao.ShowDialog(this);

            MontarGrid();
        }



        private void atualizarTiposDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizarProdutos frmAtualizarProdutos = new frmAtualizarProdutos();
            frmAtualizarProdutos.ShowDialog(this);
        }

        private void produçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroRelatorio frm = new frmFiltroRelatorio(TipoRelatorio.Producao);
            frm.ShowDialog(this);


        }

        private void expediçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroRelatorio frm = new frmFiltroRelatorio(TipoRelatorio.Expedicao);
            frm.ShowDialog(this);

            frm = null;
        }

        private void expediçãoPorLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroRelExpedicaoPorLote frm = new frmFiltroRelExpedicaoPorLote();
            frm.ShowDialog(this);

            frm = null;
        }

        private void expediçãoPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroRelatorioData frm = new frmFiltroRelatorioData();
            frm.ShowDialog(this);

            frm = null;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void definirBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSenha frmSenha = new frmSenha();
            frmSenha.ShowDialog();

            if (!frmSenha.SenhaCorreta)
            {
                return;
            }

            frmSetarDiretorio frm = new frmSetarDiretorio(Application.ExecutablePath);
            frm.ShowDialog(this);

            MessageBox.Show("Atenção! \n\nPara que as alterações tenham efeito será necessário reiniciar o programa. \n\nO mesmo será encerrado, favor abrir novamente.", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            frm = null;

            Application.Exit();
        }


        private void btnDarEntrada_Click(object sender, EventArgs e)
        {
            ItemEstoque produtoSelecionado = (ItemEstoque)gridProdutos.SelectedRows[0].DataBoundItem;
         

            //if (produto.Revenda)
            //{
            //    frmEntradaRevenda frmEntradaRevenda = new frmEntradaRevenda(produto.CodigoPreproduto, produto.CódigoDoProduto);
            //    frmEntradaRevenda.ShowDialog(this);

            //    MontarGrid();
            //}
            //else
            //{
            frmProducaoLote frmProducaoLote = new frmProducaoLote(produtoSelecionado.PreProdutoId, produtoSelecionado.Id);
                frmProducaoLote.ShowDialog(this);

                MontarGrid();
            //}
        }

        private void btnDarSaida_Click(object sender, EventArgs e)
        {
            ItemEstoque produtoSelecionado = (ItemEstoque)gridProdutos.SelectedRows[0].DataBoundItem;

            frmExpedicao frmProducaoLote = new frmExpedicao(produtoSelecionado.Id);
            frmProducaoLote.ShowDialog(this);

            MontarGrid();
        }

        private void gridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (gridProdutos.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(gridProdutos.SelectedRows[0].Cells["Estoque"].Value) == 0)
                {
                    btnDarSaida.Enabled = false;
                }
                else
                {
                    btnDarSaida.Enabled = true;
                }
            }
            else
            {
                btnDarSaida.Enabled = false;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Length > 2)
            {
                foreach (DataGridViewRow linha in gridProdutos.Rows)
                {
                    if (linha.Cells["NomeDoProduto"].Value.ToString().ToUpper().Contains(txtPesquisa.Text.ToUpper()))
                    {
                        //Vai pro final da Grid
                        gridProdutos.CurrentCell = gridProdutos.Rows[gridProdutos.Rows.Count - 1].Cells[0];
                        gridProdutos.Rows[gridProdutos.Rows.Count - 1].Selected = true;

                        //Seleciona a linha procurada
                        gridProdutos.CurrentCell = linha.Cells[0];
                        linha.Selected = true;
                        //gridProdutos.CurrentCell = gridProdutos.Rows[40].Cells[0];
                        //gridProdutos.Rows[40].Selected = true;

                        return;
                    }
                }

            }

            if (String.IsNullOrEmpty(txtPesquisa.Text.ToString().Trim()))
            {
                //Vai para o inicio da grid
                gridProdutos.CurrentCell = gridProdutos.Rows[0].Cells[0];
                gridProdutos.Rows[0].Selected = true;
            }
        }

        private void adicionarRemoverProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não disponível Ainda", "Adicionar/Remover Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public enum TipoRelatorio
    {
        Expedicao,
        Producao
    }
}