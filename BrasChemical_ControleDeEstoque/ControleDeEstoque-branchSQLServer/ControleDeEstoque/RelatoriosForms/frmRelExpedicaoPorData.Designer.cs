namespace ControleDeEstoque.RelatoriosForms
{
    partial class frmRelExpedicaoPorData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExpedicaoPorLoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ControleDeEstoque.DataSet1();
            this.ExpedicaoPorLoteTableAdapter = new ControleDeEstoque.DataSet1TableAdapters.ExpedicaoPorLoteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExpedicaoPorLoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ExpedicaoPorLoteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleDeEstoque.Relatorios.relExpedicaoPorData.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExpedicaoPorLoteBindingSource
            // 
            this.ExpedicaoPorLoteBindingSource.DataMember = "ExpedicaoPorLote";
            this.ExpedicaoPorLoteBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpedicaoPorLoteTableAdapter
            // 
            this.ExpedicaoPorLoteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelExpedicaoPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 571);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelExpedicaoPorData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos expedidos na data definida";
            this.Load += new System.EventHandler(this.frmRelExpedicaoPorData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpedicaoPorLoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExpedicaoPorLoteBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ExpedicaoPorLoteTableAdapter ExpedicaoPorLoteTableAdapter;
    }
}