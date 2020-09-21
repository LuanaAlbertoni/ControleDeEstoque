using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class Estoque
    {
        public Estoque()
        {
            this.QuantidadeProduzida = 0;
            this.QuantidadeDisponivel = 0;
            this.Expedicao = new HashSet<Expedicao>();
        }

        [Key]
        [Column(Order = 0)]
        [MaxLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Lote")]
        public string LoteID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdutoID { get; set; }

        [Display(Name = "Quantidade Produzida")]
        public int QuantidadeProduzida { get; set; }

        [Display(Name = "Quantidade Disponível")]
        public int QuantidadeDisponivel { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual OrdemFabricacao OrdemFabricacao { get; set; }
        public virtual ICollection<Expedicao> Expedicao { get; set; }
    }
}