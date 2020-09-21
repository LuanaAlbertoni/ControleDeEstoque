using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleDeEstoque.Properties;
using System.Configuration;
using System.IO;

namespace ControleDeEstoque
{
    public partial class frmSetarDiretorio : Form
    {
        private string LocalExeConfiguration;
        public frmSetarDiretorio(string localExeConfiguration)
        {
            InitializeComponent();

            LocalExeConfiguration = localExeConfiguration;
        }

        private void frmSetarDiretorio_Load(object sender, EventArgs e)
        {
            txtDiretorio.Text = new Configuracao(Application.ExecutablePath).DataBaseURL;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtDiretorio.Text = openFileDialog1.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtDiretorio.Text))
            {
                MessageBox.Show("Diretório de arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Configuracao(Application.ExecutablePath).DataBaseURL = txtDiretorio.Text;

            this.Close();
        }
    }
}
