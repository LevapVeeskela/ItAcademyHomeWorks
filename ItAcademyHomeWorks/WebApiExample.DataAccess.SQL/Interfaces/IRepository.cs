using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiExample.DataAccess.SQL.DatabaseModels.Abstraction;

namespace WebApiExample.DataAccess.SQL.Interfaces
{
    public interface IRepository<TEntity, in TKey> : IDisposable where TEntity : Entity<TKey> where TKey : struct
    {
    DbSet<TEntity> DbSet { get; }

    Task<TEntity> GetByIdAsync(TKey id);

    Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] include);

    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] include);

    void Create(TEntity instance);

    void Update(TEntity instance);

    void Delete(TEntity instance);

    Task<int> CountAsync(Expression<Func<TEntity, bool>> filter);

    Task DeleteAsync(TKey id);
    }
}