namespace ControleDeEstoque
{
    partial class frmRelatorioExpedicao
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
            this.Produtos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ControleDeEstoque.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Produtos1TableAdapter = new ControleDeEstoque.DataSet1TableAdapters.Produtos1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Produtos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Produtos1BindingSource
            // 
            this.Produtos1BindingSource.DataMember = "Produtos1";
            this.Produtos1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Produtos1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleDeEstoque.Relatorios.relExpedicaoPorProduto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 685);
            this.reportViewer1.TabIndex = 0;
            // 
            // Produtos1TableAdapter
            // 
            this.Produtos1TableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioExpedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 685);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRelatorioExpedicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Expedição";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorioExpedicao_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorioExpedicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Produtos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource Produtos1BindingSource;
        private DataSet1TableAdapters.Produtos1TableAdapter Produtos1TableAdapter;
    }
}