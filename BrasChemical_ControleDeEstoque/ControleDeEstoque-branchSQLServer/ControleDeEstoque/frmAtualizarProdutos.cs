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
    public partial class frmAtualizarProdutos : Form
    {
        ProdutosTableAdapter taProdutos;

        public frmAtualizarProdutos()
        {
            InitializeComponent();

            taProdutos = new ProdutosTableAdapter();
            taProdutos.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

            MontarListaProdutos();
            AtualizaLabel();
        }

        private void AtualizaLabel()
        {
            if (((DataSet1.ProdutosRow)listaProdutos.SelectedItem).Revenda)
            {
                lblRevenda.Text = "Revenda";
            }
            else
            {
                lblRevenda.Text = "Produzivel";
            }
        }

        private void MontarListaProdutos()
        {
            listaProdutos.DataSource = taProdutos.ObterProdutosRevenda().ToList();
        }

        private void btnProduzivel_Click(object sender, EventArgs e)
        {
            taProdutos.AtualizarRevenda(false, Convert.ToInt32(listaProdutos.SelectedValue));
            ((DataSet1.ProdutosRow)listaProdutos.SelectedItem).Revenda = false;

            SelecionarProximo();
        }


        private void btnRevenda_Click(object sender, EventArgs e)
        {
            taProdutos.AtualizarRevenda(true, Convert.ToInt32(listaProdutos.SelectedValue));
            ((DataSet1.ProdutosRow)listaProdutos.SelectedItem).Revenda = true;

            SelecionarProximo();
        }


        private void SelecionarProximo()
        {
            if (listaProdutos.SelectedIndex < listaProdutos.Items.Count)
            {
                listaProdutos.SelectedIndex = listaProdutos.SelectedIndex + 1;
            }

        }

        private void listaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaLabel();

        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "ATENÇÃO!!! \n\nOs produtos que contém SIGLA cadastrada serão entendidos como de produção. \n\nOs produtos que NÃO contém SIGLA, serão entendidos como revenda. \n\nDeseja Continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            try
            {
                PreProdutosTableAdapter taPreProdutos = new PreProdutosTableAdapter();
                taPreProdutos.Connection.ConnectionString = new Configuracao(Application.ExecutablePath).ConnectionString;

                foreach (DataSet1.ProdutosRow produto in taProdutos.ObterProdutosRevenda().ToList())
                {
                    if (string.IsNullOrEmpty(taPreProdutos.ObterSigla(produto.CodigoPreproduto)))
                    {
                        taProdutos.AtualizarRevenda(true, produto.CódigoDoProduto);
                    }
                    else
                    {
                        taProdutos.AtualizarRevenda(false, produto.CódigoDoProduto);
                    }
                }

                MessageBox.Show(this, "Produtos atualizados com sucesso!", "Atualização Concluída", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
