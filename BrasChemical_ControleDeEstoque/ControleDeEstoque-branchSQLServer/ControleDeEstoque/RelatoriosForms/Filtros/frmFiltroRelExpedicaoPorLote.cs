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

namespace ControleDeEstoque
{
    public partial class frmFiltroRelExpedicaoPorLote : Form
    {
        public frmFiltroRelExpedicaoPorLote()
        {
            InitializeComponent();

            MontaTela();
        }

        private void frmFiltroRelExpedicaoPorLote_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            frmSenha frmSenha = new frmSenha();
            frmSenha.ShowDialog(this);

            if (!frmSenha.SenhaCorreta)
            {
                this.Close();
            }

            this.Visible = true;
        }

        private void MontaTela()
        {
            try
            {
                PreProdutosRepositorio repositorio = new PreProdutosRepositorio();

                cmbPreProduto.DataSource = repositorio.SelectAll().OrderBy(x => x.Nome).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPreProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpedicaoRepositorio repositorio = new ExpedicaoRepositorio();

            listaLotes.DataSource = repositorio.SelectAll(x => x.Estoque.Produto.PreProdutoId == Convert.ToInt32(cmbPreProduto.SelectedValue)).ToList();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            PB.ProgressBar pb = new PB.ProgressBar("Gerando Relatório...");
            pb.MaxValue = 3;
            pb.Show();
            pb.Incrementar(1);
            
            frmRelExpedicaoPorLote frm = new frmRelExpedicaoPorLote(listaLotes.SelectedValue.ToString());
            pb.Incrementar(1);
            frm.Show();

            pb.Incrementar(1);
            pb.Close();
            pb = null;

            this.Close();
        }

      
    }
}
