using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeEstoque.Repositorios.Base
{
    interface IRepositorio<TEntity> where TEntity : class
    {
        IQueryable<TEntity> SelectAll();
        IQueryable<TEntity> SelectAll(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(Func<TEntity, bool> predicate);
        void Save();
    }
}
