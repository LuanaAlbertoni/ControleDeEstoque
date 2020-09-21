using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models.Json
{
    public class ViewModelOrdemFabricacao
    {
        public String LoteID { get; set; }
        public String PreProdutoNome { get; set; }
        public DateTime Data { get; set; }
    }
}