using Hotels.Domain;

namespace Hotels.DataManipulation
{
    public interface IUnitOfWork
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        void Save();
    }
}