﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class ModelViewProdutoComEstoque
    {
        public int ProdutoID { get; set; }
        public string ProdutoNome { get; set; }
        public int ProdutoLitros { get; set; }

        public string LoteID { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeExpedida { get; set; }
    }
}