using WebApiExample.DataAccess.SQL.DatabaseModels;
using WebApiExample.DataAccess.SQL.Interfaces;
using WebApiExample.DataAccess.SQL.Repositories.Abstraction;

namespace WebApiExample.DataAccess.SQL.Repositories
{
    public class MotorcycleRepository : BaseRepository<MotorcycleDbModel, int>, IMotorcycleRepository
    {
        public MotorcycleRepository(MotorcycleDbContext context)
            : base(context)
        {
        }
    }
}