using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public class Configuracao
    {
        static string CONNECTION_STRING = "ControleDeEstoque.Properties.Settings.ControleDeEstoqueConnectionString";
        string executablePath = null;

        public Configuracao()
        {
            this.executablePath = null;
        }


        public Configuracao(string executablePath)
        {
            this.executablePath = executablePath;
        }

        private Configuration ExeConfiguration
        {
            get
            {
                return ConfigurationManager.OpenExeConfiguration(String.IsNullOrEmpty(executablePath) ? Application.ExecutablePath : executablePath);
            }
        }

        public String ConnectionString
        {
            get
            {
                return ExeConfiguration.ConnectionStrings.ConnectionStrings[CONNECTION_STRING].ConnectionString.ToString();
            }
        }


        public String DataBaseURL
        {
            get
            {
                string dir = ExeConfiguration.ConnectionStrings.ConnectionStrings[CONNECTION_STRING].ConnectionString.ToString();

                return dir.Substring(dir.IndexOf("Data Source=") + 12);
            }
            set
            {
                Configuration conf = ExeConfiguration;

                conf.ConnectionStrings.ConnectionStrings[CONNECTION_STRING].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + value;
                conf.Save();
            }

        }

    }
}
