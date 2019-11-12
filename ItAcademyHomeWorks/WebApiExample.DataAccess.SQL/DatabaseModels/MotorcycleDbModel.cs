using WebApiExample.DataAccess.SQL.DatabaseModels.Abstraction;

namespace WebApiExample.DataAccess.SQL.DatabaseModels
{
    public class MotorcycleDbModel : Entity<int>
    {
        public string Model { get; set; }

        public string Description { get; set; }

        public string Owner { get; set; }

        public int? ModifierId { get; set; }
    }
}