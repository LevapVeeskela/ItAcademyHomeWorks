using WebApiExample.DataAccess.SQL.Interfaces;
using WebApiExample.DataAccess.SQL.Repositories;

namespace WebApiExample.DataAccess.SQL
{
    public class RepositoryFactory: IRepositoryFactory
    {
        private readonly MotorcycleDbContext _context;

        public RepositoryFactory(MotorcycleDbContext context)
        {
            _context = context;
        }

        public IMotorcycleRepository CreateMotorcycleRepository()
        {
            return new MotorcycleRepository(_context);
        }
    }
}