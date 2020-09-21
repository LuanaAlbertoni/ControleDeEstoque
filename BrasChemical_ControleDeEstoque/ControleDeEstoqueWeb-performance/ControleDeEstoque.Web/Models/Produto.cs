using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class Produto
    {
        public Produto()
        {
            this.Estoques = new HashSet<Estoque>();
        }

        public int ProdutoID { get; set; }
        [MaxLength(60)]
        public string Nome { get; set; }
        public int Litros { get; set; }
        public int PreProdutoID { get; set; }

        public virtual PreProduto PreProduto { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
    }
}