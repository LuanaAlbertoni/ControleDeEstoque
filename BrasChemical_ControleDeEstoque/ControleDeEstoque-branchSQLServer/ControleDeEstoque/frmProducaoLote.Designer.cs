namespace ControleDeEstoque
{
    partial class frmProducaoLote
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
            this.txtNumeroLote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.CodigoDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPreProduto
            // 
            this.cmbPreProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPreProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPreProduto.DisplayMember = "Nome";
            this.cmbPreProduto.FormattingEnabled = true;
            this.cmbPreProduto.Location = new System.Drawing.Point(31, 107);
            this.cmbPreProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPreProduto.MaxDropDownItems = 20;
            this.cmbPreProduto.Name = "cmbPreProduto";
            this.cmbPreProduto.Size = new System.Drawing.Size(835, 28);
            this.cmbPreProduto.TabIndex = 0;
            this.cmbPreProduto.ValueMember = "Id";
            this.cmbPreProduto.SelectedIndexChanged += new System.EventHandler(this.cmbPreProduto_SelectedIndexChanged);
            // 
            // txtNumeroLote
            // 
            this.txtNumeroLote.Location = new System.Drawing.Point(105, 205);
            this.txtNumeroLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroLote.Name = "txtNumeroLote";
            this.txtNumeroLote.Size = new System.Drawing.Size(176, 26);
            this.txtNumeroLote.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lote:";
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
            this.grdProdutos.Location = new System.Drawing.Point(40, 258);
            this.grdProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.RowTemplate.Height = 24;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProdutos.Size = new System.Drawing.Size(826, 295);
            this.grdProdutos.TabIndex = 3;
            this.grdProdutos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdProdutos_EditingControlShowing);
            this.grdProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProdutos_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(754, 574);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 36);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(105, 161);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(176, 26);
            this.txtData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleDeEstoque.Properties.Resources.Quimica;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produção";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 19;
            this.lineShape1.X2 = 876;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 89;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(908, 627);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // CodigoDoProduto
            // 
            this.CodigoDoProduto.DataPropertyName = "Id";
            this.CodigoDoProduto.HeaderText = "CódigoDoProduto";
            this.CodigoDoProduto.Name = "CodigoDoProduto";
            this.CodigoDoProduto.Visible = false;
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.DataPropertyName = "Nome";
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
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MaxInputLength = 4;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 120;
            // 
            // frmProducaoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 627);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grdProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroLote);
            this.Controls.Add(this.cmbPreProduto);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducaoLote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque - Produção";
            this.Load += new System.EventHandler(this.frmProducaoLote_Load);
            this.Shown += new System.EventHandler(this.frmProducaoLote_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPreProduto;
        private System.Windows.Forms.TextBox txtNumeroLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}