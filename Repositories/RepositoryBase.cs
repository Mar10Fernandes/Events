using System;
using System.Linq;
using System.Linq.Expressions;
using Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        private EventContext context;
        private DbSet<T> dbSet;

        public RepositoryBase(EventContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        #region IRepository<T> Members

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            dbSet.AddRange(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public List<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }


        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }



        public T GetById(int id)
        {
            // Sidenote: the == operator throws NotSupported Exception!
            // 'The Mapping of Interface Member is not supported'
            // Use .Equals() instead
            return dbSet.Single(e => e.ID.Equals(id));
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        

        #endregion
    }
}
