using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            try
            {
                await dbSet.AddAsync(entity);
                await _db.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, List<string>? includeProperties = null, Pagination? pagination = null, bool tracked = true)
        {
            try
            {
                IQueryable<T> query = dbSet;
                int pageSize = pagination?.PageSize ?? 0;
                int pageNum = pagination?.PageNum ?? 0;

                query = !tracked ? query.AsNoTracking() : query;

                query = filter != null ? query.Where(filter) : query;

                if (pageSize > 0 && pageNum > 0)
                {
                    pageSize = pageSize > 100 ? 100 : pageSize;
                    query = query.Skip((pageNum - 1) * pageSize).Take(pageSize);
                }
                // include properties have relationship with the entity
                if (includeProperties != null)
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        query = query.Include(includeProperty);
                    }
                }

                return await query.ToListAsync();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, List<string>? includeProperties = null)
        {
            try
            {
                IQueryable<T> query = dbSet;

                query = !tracked ? query.AsNoTracking() : query;

                query = filter != null ? query.Where(filter) : query;

                if (includeProperties != null)
                {
                    foreach (var property in includeProperties)
                    {
                        query = query.Include(property);
                    };
                }

                return await query.FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<T> RemoveAsync(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                await _db.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task SaveAsync()
        {
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
