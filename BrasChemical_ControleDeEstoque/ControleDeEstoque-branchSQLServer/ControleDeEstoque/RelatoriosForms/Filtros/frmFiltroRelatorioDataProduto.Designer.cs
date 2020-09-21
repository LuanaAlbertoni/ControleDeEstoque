namespace ControleDeEstoque
{
    partial class frmFiltroRelatorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPreProduto = new System.Windows.Forms.ComboBox();
            this.calendarioInicial = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendarioFinal = new System.Windows.Forms.MonthCalendar();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto: ";
            // 
            // cmbPreProduto
            // 
            this.cmbPreProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPreProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPreProduto.DisplayMember = "PreProduto";
            this.cmbPreProduto.FormattingEnabled = true;
            this.cmbPreProduto.Location = new System.Drawing.Point(78, 45);
            this.cmbPreProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPreProduto.Name = "cmbPreProduto";
            this.cmbPreProduto.Size = new System.Drawing.Size(454, 21);
            this.cmbPreProduto.TabIndex = 1;
            this.cmbPreProduto.ValueMember = "CodigoPreProduto";
            // 
            // calendarioInicial
            // 
            this.calendarioInicial.Location = new System.Drawing.Point(78, 102);
            this.calendarioInicial.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.calendarioInicial.MaxSelectionCount = 60;
            this.calendarioInicial.Name = "calendarioInicial";
            this.calendarioInicial.ShowToday = false;
            this.calendarioInicial.ShowTodayCircle = false;
            this.calendarioInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Inicial: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Final: ";
            // 
            // calendarioFinal
            // 
            this.calendarioFinal.Location = new System.Drawing.Point(305, 102);
            this.calendarioFinal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.calendarioFinal.MaxSelectionCount = 1;
            this.calendarioFinal.Name = "calendarioFinal";
            this.calendarioFinal.ShowToday = false;
            this.calendarioFinal.ShowTodayCircle = false;
            this.calendarioFinal.TabIndex = 5;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(427, 273);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(105, 36);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 18);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Relatorio de";
            // 
            // frmFiltroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 314);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.calendarioFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendarioInicial);
            this.Controls.Add(this.cmbPreProduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Relatório";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFiltroRelatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPreProduto;
        private System.Windows.Forms.MonthCalendar calendarioInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarioFinal;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label lblTitulo;
    }
}