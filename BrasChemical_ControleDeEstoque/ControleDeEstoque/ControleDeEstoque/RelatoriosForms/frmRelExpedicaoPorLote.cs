using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ControleDeEstoque.DataSet1TableAdapters;

namespace ControleDeEstoque
{
    public partial class frmRelExpedicaoPorLote : Form
    {
        private string Lote;

        public frmRelExpedicaoPorLote(string lote)
        {
            InitializeComponent();

            Lote = lote;
        }

        private void frmRelExpedicaoPorLote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ExpedicaoPorLote' table. You can move, or remove it, as needed.
            this.ExpedicaoPorLoteTableAdapter.Fill(this.DataSet1.ExpedicaoPorLote, Lote);

            ProducaoPorLoteTableAdapter taProducao = new ProducaoPorLoteTableAdapter();
            DataSet1.ProducaoPorLoteRow dsProducao = taProducao.TotalProduzido(Lote)[0];
            
            ReportParameter[] parametros = { new ReportParameter("parmLote", Lote),
                                             new ReportParameter("parmLitrosProduzidos", dsProducao.Litros.ToString()),
                                           };


            reportViewer1.LocalReport.SetParameters(parametros);

            this.reportViewer1.RefreshReport();

        }
    }
}
 