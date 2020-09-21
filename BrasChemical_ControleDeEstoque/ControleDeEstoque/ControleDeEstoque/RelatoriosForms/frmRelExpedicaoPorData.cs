using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ControleDeEstoque.RelatoriosForms
{
    public partial class frmRelExpedicaoPorData : Form
    {
        public DadosRelExpedicao Dados { get; set; }

      
        public frmRelExpedicaoPorData(DadosRelExpedicao dados)
        {
            InitializeComponent();

            this.Dados = dados;
        }



        private void frmRelExpedicaoPorData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ExpedicaoPorLote' table. You can move, or remove it, as needed.
            this.ExpedicaoPorLoteTableAdapter.FillByData(this.DataSet1.ExpedicaoPorLote, Dados.DataInicial, Dados.DataFinal);


            ReportParameter[] parametros = { new ReportParameter("DataInicial", Dados.DataInicial.ToString("dd/MM/yyyy")),
                                             new ReportParameter("DataFinal", Dados.DataFinal.ToString("dd/MM/yyyy"))
                                           };

            reportViewer1.LocalReport.SetParameters(parametros);
          
            reportViewer1.RefreshReport();
        }

    }
}
