using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;


namespace ControleDeEstoque
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }

        private void Installer1_AfterInstall(object sender, InstallEventArgs e)
        {
            //frmSetarDiretorio frmSetarDiretorio = new frmSetarDiretorio();
            //frmSetarDiretorio.ShowDialog();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            //System.Diagnostics.Process.Start("http://www.microsoft.com");

            frmSetarDiretorio frm = new frmSetarDiretorio(Context.Parameters["assemblypath"]);
            frm.ShowDialog();

            StreamWriter sw = new StreamWriter(@"D:\Instalacao.txt");
            

            StringDictionary myStringDictionary = Context.Parameters;
            if (Context.Parameters.Count > 0)
            {
                Console.WriteLine("Context Property : ");
                foreach (string myString in Context.Parameters.Keys)
                {
                    sw.WriteLine(myString + ": " + Context.Parameters[myString]);
                    Console.WriteLine(Context.Parameters[myString]);
                }
            }
            sw.Close();
            //System.Diagnostics.Process.Start(Application.ExecutablePath + @"\Configuracao.exe");
            
        }
    }


}
