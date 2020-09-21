using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class ModelViewFabricacao
    {
        public ModelViewFabricacao()
        {
            this.Estoques = new List<Estoque>();
        }

        public OrdemFabricacao OrdemFabricacao { get; set; }
        public List<Estoque> Estoques { get; set; }
    }
}