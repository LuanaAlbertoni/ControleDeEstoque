using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class ModelViewHome
    {
        public String LoteID { get; set; }
        public int LotesEsperando { get; set; }
        public int ProdutosEsperando { get; set; }
    }
}