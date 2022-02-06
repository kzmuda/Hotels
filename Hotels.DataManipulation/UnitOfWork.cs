using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hotels.Data;
using Hotels.Domain;

namespace Hotels.DataManipulation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelsDbContext _context;

        public UnitOfWork(HotelsDbContext context)
        {
            _context = context;
        }

        //public CountryRepository Countries => new CountryRepository(_context);
        public IGenericRepository<Country> Countries => new GenericRepository<Country>(_context);
        public IGenericRepository<Hotel> Hotels => new GenericRepository<Hotel>(_context);

        public List<Country> GetAllCountriesWithHotels(Expression<Func<Country, bool>> expression = null,
            Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy = null)
        {
            return Countries.GetAll(expression, orderBy, new List<string>(){"Hotels"});
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
