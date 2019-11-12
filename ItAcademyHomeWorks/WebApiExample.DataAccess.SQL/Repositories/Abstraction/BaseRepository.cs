using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiExample.DataAccess.SQL.DatabaseModels.Abstraction;
using WebApiExample.DataAccess.SQL.Interfaces;

namespace WebApiExample.DataAccess.SQL.Repositories.Abstraction
{
    public abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : Entity<TKey>
        where TKey : struct
    {
        protected readonly MotorcycleDbContext Context;

        protected BaseRepository(MotorcycleDbContext context)
        {
            Context = context;
        }

        public virtual DbSet<TEntity> DbSet => Context.Set<TEntity>();

        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await Context.Set<TEntity>().FindAsync(id).ConfigureAwait(false);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] include)
        {
            var entities = Context.Set<TEntity>().AsQueryable();

            entities = include.Aggregate(entities, (current, expr) => current.Include(expr));

            return await entities.ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] include)
        {
            var entities = Context.Set<TEntity>().AsQueryable();

            entities = include.Aggregate(entities, (current, expr) => current.Include(expr)).Where(filter);

            return await entities.ToListAsync().ConfigureAwait(false);
        }

        public virtual void Create(TEntity instance)
        {
            instance.Created = DateTime.Now;

            Context.Set<TEntity>().Add(instance);
        }

        public virtual void Update(TEntity instance)
        {
            instance.Modified = DateTime.Now;

            Context.Entry(instance).State = EntityState.Modified;

            Context.Entry(instance).Property(e => e.Created).IsModified = false;
        }

        public virtual void Delete(TEntity instance)
        {
            Context.Entry(instance).State = EntityState.Deleted;
        }

        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await Context.Set<TEntity>().Where(filter).CountAsync().ConfigureAwait(false);
        }

        public virtual async Task DeleteAsync(TKey id)
        {
            var instance = await GetByIdAsync(id).ConfigureAwait(false);
            Delete(instance);
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}