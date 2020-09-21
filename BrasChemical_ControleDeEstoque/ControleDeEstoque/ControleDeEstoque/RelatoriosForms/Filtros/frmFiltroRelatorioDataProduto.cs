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
    public partial class frmFiltroRelatorio : Form
    {
        public TipoRelatorio TipoRelatorio { get; set; }

        public frmFiltroRelatorio(TipoRelatorio tipoRelatorio)
        {
            InitializeComponent();

            TipoRelatorio = tipoRelatorio;
        }


        private void frmFiltroRelatorio_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            frmSenha frmSenha = new frmSenha();
            frmSenha.ShowDialog(this);

            if (!frmSenha.SenhaCorreta)
            {
                this.Close();
            }


            if (TipoRelatorio == ControleDeEstoque.TipoRelatorio.Expedicao)
            {
                lblTitulo.Text = "Relatório de Expedição";
            }
            else if (TipoRelatorio == ControleDeEstoque.TipoRelatorio.Producao)
            {
                lblTitulo.Text = "Relatório de Produção";
            }

            MontaTela();

            this.Visible = true;


        }

        private void MontaTela()
        {
            try
            {
                PreProdutosTableAdapter taPreProduto = new PreProdutosTableAdapter();

                cmbPreProduto.DataSource = taPreProduto.GetDataByPreProduto().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe esta mensagem ao administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (TipoRelatorio == ControleDeEstoque.TipoRelatorio.Expedicao)
            {
                ExibeFormularioExpedicao();
            }
            else if (TipoRelatorio == ControleDeEstoque.TipoRelatorio.Producao)
            {
                ExibeFormularioProducao();
            }

            this.Close();
        }

        private void ExibeFormularioExpedicao()
        {
            PB.ProgressBar pb = new PB.ProgressBar("Gerando Relatório...");
            pb.MaxValue = 3;
            pb.Show();
            pb.Incrementar(1);
            
            DadosRelExpedicao dados = new DadosRelExpedicao();

            dados.NomePreProduto = ((DataSet1.PreProdutosRow)(cmbPreProduto.SelectedItem)).PreProduto;
            dados.CodigoPreProduto = Convert.ToInt32(cmbPreProduto.SelectedValue);

            DateTime DI = calendarioInicial.SelectionStart;
            dados.DataInicial = new DateTime(DI.Year, DI.Month, DI.Day, 00, 00, 00);

            DateTime DF = calendarioFinal.SelectionStart;
            dados.DataFinal = new DateTime(DF.Year, DF.Month, DF.Day, 23, 59, 59);

            frmRelatorioExpedicao frmRelatorioProducao = new frmRelatorioExpedicao(dados);
            pb.Incrementar(1);
            this.Visible = false;
            frmRelatorioProducao.Show();

            pb.Incrementar(1);
            pb.Close();
            pb = null;

            frmRelatorioProducao = null;
        }


        private void ExibeFormularioProducao()
        {
            
        }

    }
}
