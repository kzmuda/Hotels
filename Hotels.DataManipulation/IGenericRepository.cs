using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hotels.DataManipulation
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            List<string> includes = null);

        T Get(Expression<Func<T, bool>> expression = null,
            List<string> includes = null);

        void Add(T entity);
    }
}