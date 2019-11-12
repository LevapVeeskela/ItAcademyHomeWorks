using WebApiExample.DataAccess.SQL.DatabaseModels;

namespace WebApiExample.DataAccess.SQL.Interfaces
{
    public interface IMotorcycleRepository : IRepository<MotorcycleDbModel, int>
    {
        
    }
}