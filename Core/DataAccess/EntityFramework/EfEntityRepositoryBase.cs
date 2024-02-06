using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public async Task AddAsync(TEntity entity)
    {
        using (var context=new TContext())
        {
           await context.AddAsync(entity);
           await context.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(int id)
    {
        using (var context=new TContext())
        {
            var entity=context.Set<TEntity>().Find(id);
             context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

        }
    }

    public Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
    {
        using (var context=new TContext())
        {
            return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
        }
    }

    public async Task UpdateAsync(TEntity entity)
    {
        using (var context=new TContext())
        {
             context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
