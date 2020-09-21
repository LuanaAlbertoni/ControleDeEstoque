namespace ControleDeEstoque
{
    partial class frmAtualizarProdutos
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
            this.listaProdutos = new System.Windows.Forms.ListBox();
            this.btnRevenda = new System.Windows.Forms.Button();
            this.btnProduzivel = new System.Windows.Forms.Button();
            this.lblRevenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutomatico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaProdutos
            // 
            this.listaProdutos.DisplayMember = "NomeDoProduto";
            this.listaProdutos.FormattingEnabled = true;
            this.listaProdutos.ItemHeight = 20;
            this.listaProdutos.Location = new System.Drawing.Point(90, 100);
            this.listaProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(700, 264);
            this.listaProdutos.TabIndex = 0;
            this.listaProdutos.ValueMember = "CódigoDoProduto";
            this.listaProdutos.SelectedIndexChanged += new System.EventHandler(this.listaProdutos_SelectedIndexChanged);
            // 
            // btnRevenda
            // 
            this.btnRevenda.Location = new System.Drawing.Point(90, 433);
            this.btnRevenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevenda.Name = "btnRevenda";
            this.btnRevenda.Size = new System.Drawing.Size(344, 88);
            this.btnRevenda.TabIndex = 1;
            this.btnRevenda.Text = "Revenda";
            this.btnRevenda.UseVisualStyleBackColor = true;
            this.btnRevenda.Click += new System.EventHandler(this.btnRevenda_Click);
            // 
            // btnProduzivel
            // 
            this.btnProduzivel.Location = new System.Drawing.Point(442, 436);
            this.btnProduzivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduzivel.Name = "btnProduzivel";
            this.btnProduzivel.Size = new System.Drawing.Size(350, 84);
            this.btnProduzivel.TabIndex = 2;
            this.btnProduzivel.Text = "Produzivel";
            this.btnProduzivel.UseVisualStyleBackColor = true;
            this.btnProduzivel.Click += new System.EventHandler(this.btnProduzivel_Click);
            // 
            // lblRevenda
            // 
            this.lblRevenda.AutoSize = true;
            this.lblRevenda.Location = new System.Drawing.Point(412, 384);
            this.lblRevenda.Name = "lblRevenda";
            this.lblRevenda.Size = new System.Drawing.Size(51, 20);
            this.lblRevenda.TabIndex = 3;
            this.lblRevenda.Text = "label1";
            this.lblRevenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atualizar tipos de Produtos:";
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.Location = new System.Drawing.Point(90, 529);
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.Size = new System.Drawing.Size(702, 48);
            this.btnAutomatico.TabIndex = 5;
            this.btnAutomatico.Text = "Automatico";
            this.btnAutomatico.UseVisualStyleBackColor = true;
            this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CUIDADO!";
            // 
            // frmAtualizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAutomatico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRevenda);
            this.Controls.Add(this.btnProduzivel);
            this.Controls.Add(this.btnRevenda);
            this.Controls.Add(this.listaProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAtualizarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAtualizarProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaProdutos;
        private System.Windows.Forms.Button btnRevenda;
        private System.Windows.Forms.Button btnProduzivel;
        private System.Windows.Forms.Label lblRevenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutomatico;
        private System.Windows.Forms.Label label2;
    }
}