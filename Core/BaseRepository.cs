using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using ECommerceAPI.Context;

namespace ECommerceAPI.Core;
public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity:Entity
{
    protected ECommerceDbContext _context;
    public BaseRepository(ECommerceDbContext eCommerceDbContext)
    {
        _context = eCommerceDbContext;
    }

    protected IQueryable<TEntity> Query()
    {
        return _context.Set<TEntity>();
    }

    public IEnumerable<TEntity> GetAll(
        Expression<Func<TEntity, bool>>? predicate = null, 
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, 
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
    {
        var query = Query();
        if (predicate != null) query = query.Where(predicate);
        if (include != null) query = include(query);
        if (orderBy != null) query = orderBy(query);
        return query;
    }
    public TEntity? Get(Expression<Func<TEntity, bool>>? predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
    {
        var getQuery = Query().Where(predicate);
        if (include != null) getQuery = include(getQuery);
        return getQuery.FirstOrDefault();
    }


    public TEntity Add(TEntity entity)
    {
        _context.Entry<TEntity>(entity).State = EntityState.Added;
        _context.SaveChanges();
        return entity;
    }


    public TEntity Update(TEntity entity)
    {
        _context.Entry<TEntity>(entity).State = EntityState.Modified;
        _context.SaveChanges();
        return entity;
    }
    public TEntity Delete(TEntity entity)
    {
        _context.Entry<TEntity>(entity).State = EntityState.Deleted;
        _context.SaveChanges();
        return entity;
    }
}
