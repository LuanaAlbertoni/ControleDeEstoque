using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeEstoque.Model
{
    public class Lote
    {
        public string Sigla { get; set; }
        public int Ano { get; set; }
        public int Numero { get; set; }

        public Lote()
        {
            Sigla = string.Empty;
            Ano = 0;
            Numero = 0;
        }

        public override string ToString()
        {
            return Sigla + @"/" + Ano.ToString("00") + "-" + Numero.ToString("000");
        }
    }
}
