using ControleDeEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.DAL
{
    public class ControleEstoqueInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ControleEstoqueContext>
    {
        //protected override void Seed(ControleEstoqueContext context)
        //{
        //    var preProdutos = new List<PreProduto>
        //    {
        //        new PreProduto{PreProdutoID = 1, Nome = "Autobras", Sigla = "AUT"},
        //        new PreProduto{PreProdutoID = 2, Nome = "Solubras", Sigla = "SOL"},
        //        new PreProduto{PreProdutoID = 3, Nome = "Interbras", Sigla = "INT"},
        //    };
        //    preProdutos.ForEach(s => context.PreProdutos.Add(s));
        //    context.SaveChanges();

        //    var produtos = new List<Produto>
        //    {
        //        new Produto{PreProdutoID = 1, Nome = "Autobras 5 Litros", Litros = 5},
        //        new Produto{PreProdutoID = 1, Nome = "Autobras 10 Litros", Litros = 10},
        //        new Produto{PreProdutoID = 1, Nome = "Autobras 20 Litros", Litros = 20},
        //        new Produto{PreProdutoID = 1, Nome = "Autobras 50 Litros", Litros = 50},

        //        new Produto{PreProdutoID = 2, Nome = "Solubras 5 Litros", Litros = 5},
        //        new Produto{PreProdutoID = 2, Nome = "Solubras 10 Litros", Litros = 10},
        //        new Produto{PreProdutoID = 2, Nome = "Solubras 20 Litros", Litros = 20},
        //        new Produto{PreProdutoID = 2, Nome = "Solubras 50 Litros", Litros = 50},

        //        new Produto{PreProdutoID = 3, Nome = "Interbras 5 Litros", Litros = 5},
        //        new Produto{PreProdutoID = 3, Nome = "Interbras 10 Litros", Litros = 10},
        //        new Produto{PreProdutoID = 3, Nome = "Interbras 20 Litros", Litros = 20},
        //        new Produto{PreProdutoID = 3, Nome = "Interbras 50 Litros", Litros = 50},
        //    };
        //    produtos.ForEach(s => context.Produtos.Add(s));
        //    context.SaveChanges();
        //}
    }
}