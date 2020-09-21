namespace ControleDeEstoque
{
    partial class frmEntradaRevenda
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.CodigoDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPreProduto
            // 
            this.cmbPreProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPreProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPreProduto.DisplayMember = "PreProduto";
            this.cmbPreProduto.FormattingEnabled = true;
            this.cmbPreProduto.Location = new System.Drawing.Point(33, 119);
            this.cmbPreProduto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmbPreProduto.Name = "cmbPreProduto";
            this.cmbPreProduto.Size = new System.Drawing.Size(823, 28);
            this.cmbPreProduto.TabIndex = 1;
            this.cmbPreProduto.ValueMember = "CodigoPreProduto";
            this.cmbPreProduto.SelectedIndexChanged += new System.EventHandler(this.cmbPreProduto_SelectedIndexChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(115, 188);
            this.txtData.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(187, 26);
            this.txtData.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(691, 557);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(168, 56);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entrada de produtos para revenda";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 881;
            this.lineShape1.Y1 = 93;
            this.lineShape1.Y2 = 93;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(929, 634);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.AllowUserToResizeColumns = false;
            this.grdProdutos.AllowUserToResizeRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDoProduto,
            this.NomeDoProduto,
            this.Litros,
            this.Quantidade});
            this.grdProdutos.Location = new System.Drawing.Point(33, 228);
            this.grdProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.RowTemplate.Height = 24;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProdutos.Size = new System.Drawing.Size(826, 295);
            this.grdProdutos.TabIndex = 12;
            this.grdProdutos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdProdutos_EditingControlShowing);
            this.grdProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProdutos_KeyDown);
            // 
            // CodigoDoProduto
            // 
            this.CodigoDoProduto.DataPropertyName = "CódigoDoProduto";
            this.CodigoDoProduto.HeaderText = "CódigoDoProduto";
            this.CodigoDoProduto.Name = "CodigoDoProduto";
            this.CodigoDoProduto.Visible = false;
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.DataPropertyName = "NomeDoProduto";
            this.NomeDoProduto.HeaderText = "Nome";
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.ReadOnly = true;
            this.NomeDoProduto.Width = 600;
            // 
            // Litros
            // 
            this.Litros.DataPropertyName = "Litros";
            this.Litros.HeaderText = "Litros";
            this.Litros.Name = "Litros";
            this.Litros.ReadOnly = true;
            this.Litros.Width = 60;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MaxInputLength = 5;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data:";
            // 
            // frmEntradaRevenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdProdutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmbPreProduto);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntradaRevenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque - Entrada de Produtos para Revenda";
            this.Load += new System.EventHandler(this.frmEntradaRevenda_Load);
            this.Shown += new System.EventHandler(this.frmEntradaRevenda_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPreProduto;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}