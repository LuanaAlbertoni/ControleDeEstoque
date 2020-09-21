using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public enum TipoMateriaPrima
    {
        MateriaPrima = 1, 
        Embalagem = 2, 
        Corante = 3, 
        Essencia = 4
    }

    public class MateriaPrima
    {
        public MateriaPrima() { }

        [Key]
        [MaxLength(4)]
        public string MateriaPrimaID { get; set; }
        
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        
        [MaxLength(15)]
        public string CAS { get; set; }
        
        [MaxLength(10)]
        public string CodigoInterno { get; set; }
        
        [MaxLength(10)]
        public string NCM { get; set; }
        
        public float Densidade { get; set; }

        [Required]
        public TipoMateriaPrima Tipo { get; set; }

        //public virtual ICollPreection<Produto> Produtos { get; set; }
        // public virtual ICollection<OrdemFabricacao> OrdensFabricacao { get; set; }
    }

}