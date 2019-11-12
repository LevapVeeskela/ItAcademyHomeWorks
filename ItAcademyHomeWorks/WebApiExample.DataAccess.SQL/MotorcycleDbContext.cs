using Microsoft.EntityFrameworkCore;
using WebApiExample.DataAccess.SQL.DatabaseModels;

namespace WebApiExample.DataAccess.SQL
{
    public class MotorcycleDbContext : DbContext
    {
        public virtual DbSet<MotorcycleDbModel> Motorcycle { get; set; }

        public MotorcycleDbContext(DbContextOptions<MotorcycleDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}