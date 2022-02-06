using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AAA.Common;

namespace Hotels.DataManipulation
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            List<string> includes = null);

        T Get(Expression<Func<T, bool>> expression = null,
            List<string> includes = null);

        PagedList<T> GetAllParams(RequestParameters requestParameters);

        void Add(T entity);
    }
}