namespace WebApiExample.DataAccess.SQL.Interfaces
{
    public interface IRepositoryFactory
    {
        IMotorcycleRepository CreateMotorcycleRepository();
    }
}