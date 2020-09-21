using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ControleDeEstoque
{
    public partial class frmRelatorioExpedicao : Form
    {
        public DadosRelExpedicao Dados { get; set; }

        public frmRelatorioExpedicao(DadosRelExpedicao dados)
        {
            InitializeComponent();

            this.Dados = dados;
        }

        private void frmRelatorioExpedicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Produtos1' table. You can move, or remove it, as needed.
            this.Produtos1TableAdapter.Fill(this.DataSet1.Produtos1, Dados.CodigoPreProduto, Dados.DataInicial, Dados.DataFinal);

            ReportParameter[] parametros = { new ReportParameter("NomeDoPreProduto", Dados.NomePreProduto),
                                             new ReportParameter("DataInicial", Dados.DataInicial.ToString("dd/MM/yyyy")),
                                             new ReportParameter("DataFinal", Dados.DataFinal.ToString("dd/MM/yyyy"))
                                           };
            
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.RefreshReport();
        }

        private void frmRelatorioExpedicao_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportViewer1.Clear();
            GC.Collect();
            
        }


    }

    public class DadosRelExpedicao
    {
        public String NomePreProduto { get; set; }
        public int CodigoPreProduto { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }


        public DadosRelExpedicao()
        {
            this.NomePreProduto = "";
            this.CodigoPreProduto = 0;
            this.DataInicial = DateTime.Now;
            this.DataFinal = DateTime.Now;
        }

        public DadosRelExpedicao(String nomeProduto, int codigoPreProduto, DateTime dataInicial, DateTime dataFinal)
        {
            this.NomePreProduto = nomeProduto;
            this.CodigoPreProduto = codigoPreProduto;
            this.DataInicial = dataInicial;
            this.DataFinal = dataFinal;
        }
    }
}
