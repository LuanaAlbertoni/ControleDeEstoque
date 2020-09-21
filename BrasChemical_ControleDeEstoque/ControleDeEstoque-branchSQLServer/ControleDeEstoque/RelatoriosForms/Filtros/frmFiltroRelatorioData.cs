using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleDeEstoque.DataSet1TableAdapters;
using ControleDeEstoque.RelatoriosForms;

namespace ControleDeEstoque
{
    public partial class frmFiltroRelatorioData : Form
    {

        public frmFiltroRelatorioData()
        {
            InitializeComponent();

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

            this.Visible = true;
        }



        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            PB.ProgressBar pb = new PB.ProgressBar("Gerando Relatório...");
            pb.MaxValue = 3;
            pb.Show();
            pb.Incrementar(1);

            DadosRelExpedicao dados = new DadosRelExpedicao();

            DateTime DI = calendarioInicial.SelectionStart;
            dados.DataInicial = new DateTime(DI.Year, DI.Month, DI.Day, 00, 00, 00);

            DateTime DF = calendarioFinal.SelectionStart;
            dados.DataFinal = new DateTime(DF.Year, DF.Month, DF.Day, 23, 59, 59);

            frmRelExpedicaoPorData frmRelatorioProducao = new frmRelExpedicaoPorData(dados);
            pb.Incrementar(1);
            this.Visible = false;
            frmRelatorioProducao.Show();

            pb.Incrementar(1);
            pb.Close();
            pb = null;

            this.Close();
        }


    }
}
