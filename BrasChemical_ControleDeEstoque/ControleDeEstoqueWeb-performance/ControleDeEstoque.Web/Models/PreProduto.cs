using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class PreProduto
    {
        public PreProduto()
        {
            this.Produtos = new HashSet<Produto>();
            this.OrdensFabricacao = new HashSet<OrdemFabricacao>();
        }

        public int PreProdutoID { get; set; }
        [MaxLength(60)]
        public string Nome { get; set; }
        [MaxLength(10)]
        public string Sigla { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<OrdemFabricacao> OrdensFabricacao { get; set; }
    }
}