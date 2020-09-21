using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class Expedicao
    {
        public  Expedicao()
        {
            this.Data = DateTime.Now;
        }
        public int ExpedicaoID { get; set; }
        [MaxLength(20)]
        [Display(Name = "Lote")]
        public string EstoqueLoteID { get; set; }
        public int EstoqueProdutoID { get; set; }
        public System.DateTime Data { get; set; }
        public int Quantidade { get; set; }

        public virtual Estoque Estoque { get; set; }
    }
}