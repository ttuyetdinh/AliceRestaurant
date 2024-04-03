using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, List<string>? includeProperties = null, Pagination? pagination = null, bool tracked = true);
        Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, List<string>? includeProperties = null);
        Task<T> CreateAsync(T entity);
        Task<T> RemoveAsync(T entity);
        Task SaveAsync();
    }
}