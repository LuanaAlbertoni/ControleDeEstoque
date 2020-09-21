using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeEstoque.Model
{
    public class ItemEstoque
    {
        public int Id { get; set; }
        public int PreProdutoId { get; set; }
        public string Nome { get; set; }
        public int SomaEstoque { get; set; }
    }
}
