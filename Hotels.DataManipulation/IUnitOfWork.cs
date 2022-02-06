using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hotels.Domain;

namespace Hotels.DataManipulation
{
    public interface IUnitOfWork
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }

        List<Country> GetAllCountriesWithHotels(Expression<Func<Country, bool>> expression = null,
            Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy = null);
        void Save();
    }
}