using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IDishHistoryRepository : IRepository<DishHistory>
    {
        Task<DishHistory> UpdateAsync(DishHistory entity);
    }
}