namespace ControleDeEstoque
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarTiposDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarRemoverProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.definirBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.expediçãoPorLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.expediçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expediçãoPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDarEntrada = new System.Windows.Forms.Button();
            this.btnProducao = new System.Windows.Forms.Button();
            this.btnEntradaRevenda = new System.Windows.Forms.Button();
            this.btnExpedicao = new System.Windows.Forms.Button();
            this.dataSet1 = new ControleDeEstoque.DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnDarSaida = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarTiposDeProdutosToolStripMenuItem,
            this.adicionarRemoverProdutosToolStripMenuItem,
            this.toolStripSeparator3,
            this.definirBancoDeDadosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.produtosToolStripMenuItem.Text = "Configurações";
            // 
            // atualizarTiposDeProdutosToolStripMenuItem
            // 
            this.atualizarTiposDeProdutosToolStripMenuItem.Name = "atualizarTiposDeProdutosToolStripMenuItem";
            this.atualizarTiposDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.atualizarTiposDeProdutosToolStripMenuItem.Text = "Atualizar Tipos de Produtos ";
            this.atualizarTiposDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.atualizarTiposDeProdutosToolStripMenuItem_Click);
            // 
            // adicionarRemoverProdutosToolStripMenuItem
            // 
            this.adicionarRemoverProdutosToolStripMenuItem.Name = "adicionarRemoverProdutosToolStripMenuItem";
            this.adicionarRemoverProdutosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.adicionarRemoverProdutosToolStripMenuItem.Text = "Adicionar/Remover Produtos";
            this.adicionarRemoverProdutosToolStripMenuItem.Click += new System.EventHandler(this.adicionarRemoverProdutosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // definirBancoDeDadosToolStripMenuItem
            // 
            this.definirBancoDeDadosToolStripMenuItem.Name = "definirBancoDeDadosToolStripMenuItem";
            this.definirBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.definirBancoDeDadosToolStripMenuItem.Text = "Definir Banco de Dados";
            this.definirBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.definirBancoDeDadosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produçãoToolStripMenuItem,
            this.toolStripSeparator1,
            this.expediçãoPorLoteToolStripMenuItem,
            this.toolStripSeparator2,
            this.expediçãoToolStripMenuItem,
            this.expediçãoPorDataToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.Enabled = false;
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.produçãoToolStripMenuItem.Text = "Produção";
            this.produçãoToolStripMenuItem.Click += new System.EventHandler(this.produçãoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // expediçãoPorLoteToolStripMenuItem
            // 
            this.expediçãoPorLoteToolStripMenuItem.Name = "expediçãoPorLoteToolStripMenuItem";
            this.expediçãoPorLoteToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.expediçãoPorLoteToolStripMenuItem.Text = "Expedição por Lote";
            this.expediçãoPorLoteToolStripMenuItem.Click += new System.EventHandler(this.expediçãoPorLoteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // expediçãoToolStripMenuItem
            // 
            this.expediçãoToolStripMenuItem.Name = "expediçãoToolStripMenuItem";
            this.expediçãoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.expediçãoToolStripMenuItem.Text = "Expedição por Produto e Data";
            this.expediçãoToolStripMenuItem.Click += new System.EventHandler(this.expediçãoToolStripMenuItem_Click);
            // 
            // expediçãoPorDataToolStripMenuItem
            // 
            this.expediçãoPorDataToolStripMenuItem.Name = "expediçãoPorDataToolStripMenuItem";
            this.expediçãoPorDataToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.expediçãoPorDataToolStripMenuItem.Text = "Expedição por Data";
            this.expediçãoPorDataToolStripMenuItem.Click += new System.EventHandler(this.expediçãoPorDataToolStripMenuItem_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AllowUserToOrderColumns = true;
            this.gridProdutos.AllowUserToResizeRows = false;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoProduto,
            this.CodigoProduto,
            this.Estoque});
            this.gridProdutos.Location = new System.Drawing.Point(24, 76);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(5);
            this.gridProdutos.MultiSelect = false;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowTemplate.Height = 24;
            this.gridProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(563, 575);
            this.gridProdutos.TabIndex = 1;
            this.gridProdutos.SelectionChanged += new System.EventHandler(this.gridProdutos_SelectionChanged);
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.DataPropertyName = "NomeDoProduto";
            this.NomeDoProduto.HeaderText = "Produto";
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.ReadOnly = true;
            this.NomeDoProduto.Width = 450;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "CodigoProduto";
            this.CodigoProduto.HeaderText = "CodigoProduto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            this.CodigoProduto.Visible = false;
            // 
            // Estoque
            // 
            this.Estoque.DataPropertyName = "SomaEstoque";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estoque.DefaultCellStyle = dataGridViewCellStyle1;
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // btnDarEntrada
            // 
            this.btnDarEntrada.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarEntrada.Location = new System.Drawing.Point(24, 658);
            this.btnDarEntrada.Margin = new System.Windows.Forms.Padding(5);
            this.btnDarEntrada.Name = "btnDarEntrada";
            this.btnDarEntrada.Size = new System.Drawing.Size(192, 32);
            this.btnDarEntrada.TabIndex = 2;
            this.btnDarEntrada.Text = "Dar Entrada";
            this.btnDarEntrada.UseVisualStyleBackColor = true;
            this.btnDarEntrada.Click += new System.EventHandler(this.btnDarEntrada_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(741, 43);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(205, 63);
            this.btnProducao.TabIndex = 3;
            this.btnProducao.Text = "Produção";
            this.btnProducao.UseVisualStyleBackColor = true;
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnEntradaRevenda
            // 
            this.btnEntradaRevenda.Location = new System.Drawing.Point(741, 131);
            this.btnEntradaRevenda.Name = "btnEntradaRevenda";
            this.btnEntradaRevenda.Size = new System.Drawing.Size(205, 63);
            this.btnEntradaRevenda.TabIndex = 4;
            this.btnEntradaRevenda.Text = "Entrada de Produtos Revenda";
            this.btnEntradaRevenda.UseVisualStyleBackColor = true;
            this.btnEntradaRevenda.Visible = false;
            this.btnEntradaRevenda.Click += new System.EventHandler(this.btnEntradaRevenda_Click);
            // 
            // btnExpedicao
            // 
            this.btnExpedicao.Location = new System.Drawing.Point(741, 265);
            this.btnExpedicao.Name = "btnExpedicao";
            this.btnExpedicao.Size = new System.Drawing.Size(205, 63);
            this.btnExpedicao.TabIndex = 5;
            this.btnExpedicao.Text = "Expedição";
            this.btnExpedicao.UseVisualStyleBackColor = true;
            this.btnExpedicao.Click += new System.EventHandler(this.btnExpedicao_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleDeEstoque.Properties.Resources.Quimica;
            this.pictureBox1.Location = new System.Drawing.Point(668, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControleDeEstoque.Properties.Resources.Sprinter;
            this.pictureBox2.Location = new System.Drawing.Point(655, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 59);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1028, 704);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 649;
            this.lineShape2.X2 = 982;
            this.lineShape2.Y1 = 230;
            this.lineShape2.Y2 = 229;
            // 
            // btnDarSaida
            // 
            this.btnDarSaida.Location = new System.Drawing.Point(357, 658);
            this.btnDarSaida.Name = "btnDarSaida";
            this.btnDarSaida.Size = new System.Drawing.Size(192, 32);
            this.btnDarSaida.TabIndex = 10;
            this.btnDarSaida.Text = "Dar Saida";
            this.btnDarSaida.UseVisualStyleBackColor = true;
            this.btnDarSaida.Click += new System.EventHandler(this.btnDarSaida_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControleDeEstoque.Properties.Resources.Quimica;
            this.pictureBox3.Location = new System.Drawing.Point(224, 658);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ControleDeEstoque.Properties.Resources.Sprinter;
            this.pictureBox4.Location = new System.Drawing.Point(555, 659);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(24, 43);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(563, 26);
            this.txtPesquisa.TabIndex = 13;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 704);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnDarSaida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExpedicao);
            this.Controls.Add(this.btnEntradaRevenda);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.btnDarEntrada);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Bras Chemical - Controle de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarTiposDeProdutosToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridProdutos;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button btnDarEntrada;
        private System.Windows.Forms.Button btnProducao;
        private System.Windows.Forms.Button btnEntradaRevenda;
        private System.Windows.Forms.Button btnExpedicao;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expediçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expediçãoPorLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expediçãoPorDataToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem definirBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.Button btnDarSaida;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ToolStripMenuItem adicionarRemoverProdutosToolStripMenuItem;
    }
}