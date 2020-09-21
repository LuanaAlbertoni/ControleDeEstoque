using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PB
{
    public partial class ProgressBar : Form
    {
        #region Atributos

        private int _minValue;
        private int _maxValue;
        private int _step;
        private ProgressBarStyle _style;
        private string _titulo;
        #endregion

        #region Propriedades

        public ProgressBarStyle Style
        {
            get { return _style; }
            set { _style = value; }
        }

        public int MinValue
        {
            get { return _minValue; }
            set { _minValue = value; }
        }

        public int MaxValue
        {
            get { return _maxValue; }
            set { _maxValue = value; }
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;

            }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public ProgressBar()
        {
            this.MinValue = 0;
            this.MaxValue = 0;
            this.Step = 1;
            this.Style = ProgressBarStyle.Blocks;
            this.Titulo = "Processo em andamento. Aguarde...";

            InitializeComponent();
        }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="sTitulo">Titulo</param>
        public ProgressBar(string sTitulo)
        {
            this.MinValue = 0;
            this.MaxValue = 0;
            this.Step = 1;
            this.Style = ProgressBarStyle.Blocks;
            this.Titulo = sTitulo;

            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void ProgressBar_Shown(object sender, EventArgs e)
        {
            pbStatus.Minimum = this.MinValue;
            pbStatus.Maximum = this.MaxValue;
            pbStatus.Style = this.Style;
            pbStatus.Step = this.Step;

            lblTitulo.Text = this.Titulo;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            pbStatus.Minimum = this.MinValue;
            pbStatus.Maximum = this.MaxValue;
            pbStatus.Style = this.Style;
            pbStatus.Step = this.Step;

            lblTitulo.Text = this.Titulo;
        }

        #endregion

        #region Métodos

        public void Incrementar(int value)
        {
            pbStatus.Increment(value);
            this.Refresh();
        }

        public void LimparProgressBar()
        {
            pbStatus.Value = 0;
        }

        public void AlterarDescricao(string descricao)
        {
            this.Refresh();
        }

        #endregion

       


    }
}
