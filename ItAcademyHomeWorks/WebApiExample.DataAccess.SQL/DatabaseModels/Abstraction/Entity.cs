using System;

namespace WebApiExample.DataAccess.SQL.DatabaseModels.Abstraction
{
    public abstract class Entity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime? Modified { get; set; }
    }
}