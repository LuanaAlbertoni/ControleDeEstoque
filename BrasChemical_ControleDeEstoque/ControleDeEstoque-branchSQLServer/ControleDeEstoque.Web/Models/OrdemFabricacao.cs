using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class OrdemFabricacao
    {
        public OrdemFabricacao()
        {
            this.Data = DateTime.Now;
            this.Envasado = false;
        }

        [Key]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Lote")]
        public string LoteID { get; set; }
        public int PreProdutoID { get; set; }

        public System.DateTime Data { get; set; }
        public bool Envasado { get; set; }
        [Display(Name = "Data Produção")]
        public Nullable<System.DateTime> DataProducao { get; set; }

        public virtual PreProduto PreProduto { get; set; }
    }
}