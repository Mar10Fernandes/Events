using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Events.Repository.Repositories.EntityFramework.Base
{
    public interface IRepository<T>
    {
        void Delete(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        void Add(T entity);
        void Update(T entity);

        void AddRange(IEnumerable<T> entity);

        List<T> GetAll();

        void Save();
    }
}
