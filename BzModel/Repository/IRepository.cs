using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BzModel.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);

        T Select(Expression<Func<T, bool>> predicate);

        IQueryable<T> Selects();

        void Update(T entity);

        void Delete(T entity);

        void SaveChanges();

    }
}