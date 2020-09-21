using ControleDeEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.DAL
{
    public class ControleEstoqueContext : DbContext
    {
        public ControleEstoqueContext()
            : base("ControleEstoqueContext")
        {

        }

        public DbSet<PreProduto> PreProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Expedicao> Expedicoes { get; set; }
        public DbSet<OrdemFabricacao> OrdensFabricacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}