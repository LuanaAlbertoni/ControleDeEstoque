using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ControleDeEstoque.Repositorios.Base
{
    public abstract class Repositorio<TEntity> : IDisposable, IRepositorio<TEntity> where TEntity : class
    {
        DBControleEstoqueContainer ctx = new DBControleEstoqueContainer();

        public IQueryable<TEntity> SelectAll()
        {
            return ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> SelectAll(Func<TEntity, bool> predicate)
        {
            return SelectAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public void Add(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Update(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public void Delete(TEntity obj)
        {
            var dbset = ctx.Set<TEntity>();

            if (ctx.Entry(obj).State == EntityState.Detached)
            {
                dbset.Attach(obj);
            }

            dbset.Remove(obj);
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
