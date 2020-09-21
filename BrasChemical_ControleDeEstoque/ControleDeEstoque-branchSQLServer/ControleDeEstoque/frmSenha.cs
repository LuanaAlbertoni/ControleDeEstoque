using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class frmSenha : Form
    {
        public bool SenhaCorreta { get; set; }

        public frmSenha()
        {
            InitializeComponent();
            SenhaCorreta = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("333"))
            {
                SenhaCorreta = true;
                txtSenha.Focus();
                this.Close();
            }

            else
            {
                MessageBox.Show("Senha Incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
