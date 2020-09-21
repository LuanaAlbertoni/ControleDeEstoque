using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeEstoque.Repositorios
{
    public class ProdutosRepositorio : Repositorios.Base.Repositorio<Produto>
    {
        public IQueryable<Produto> SelectAllProduziveis(int preProdutoId)
        {
            return SelectAll()
                .Where(x => x.PreProdutoId == preProdutoId)
                .Where(x => x.Revenda.HasValue && x.Revenda.Value == false);
        }
    }
}
