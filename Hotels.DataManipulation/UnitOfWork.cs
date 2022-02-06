using System;
using System.Collections.Generic;
using System.Linq;
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

        public IGenericRepository<Country> Countries => new GenericRepository<Country>(_context);
        public IGenericRepository<Hotel> Hotels => new GenericRepository<Hotel>(_context);


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
