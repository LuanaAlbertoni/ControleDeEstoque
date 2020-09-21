namespace ControleDeEstoque
{
    partial class frmFiltroRelExpedicaoPorLote
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
            this.cmbPreProduto = new System.Windows.Forms.ComboBox();
            this.listaLotes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPreProduto
            // 
            this.cmbPreProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPreProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPreProduto.DisplayMember = "PreProduto";
            this.cmbPreProduto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreProduto.FormattingEnabled = true;
            this.cmbPreProduto.Location = new System.Drawing.Point(82, 11);
            this.cmbPreProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPreProduto.Name = "cmbPreProduto";
            this.cmbPreProduto.Size = new System.Drawing.Size(317, 22);
            this.cmbPreProduto.TabIndex = 0;
            this.cmbPreProduto.ValueMember = "CodigoPreProduto";
            this.cmbPreProduto.SelectedIndexChanged += new System.EventHandler(this.cmbPreProduto_SelectedIndexChanged);
            // 
            // listaLotes
            // 
            this.listaLotes.DisplayMember = "Lote";
            this.listaLotes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLotes.FormattingEnabled = true;
            this.listaLotes.ItemHeight = 14;
            this.listaLotes.Location = new System.Drawing.Point(82, 54);
            this.listaLotes.Margin = new System.Windows.Forms.Padding(2);
            this.listaLotes.Name = "listaLotes";
            this.listaLotes.Size = new System.Drawing.Size(84, 172);
            this.listaLotes.TabIndex = 1;
            this.listaLotes.ValueMember = "Lote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lote:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(315, 202);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(84, 24);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Exibir";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmFiltroRelExpedicaoPorLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 242);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaLotes);
            this.Controls.Add(this.cmbPreProduto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroRelExpedicaoPorLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Expedição Por Lote";
            this.Load += new System.EventHandler(this.frmFiltroRelExpedicaoPorLote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPreProduto;
        private System.Windows.Forms.ListBox listaLotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContinuar;
    }
}