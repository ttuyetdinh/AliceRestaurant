using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IDishRepository : IRepository<Dish>
    {
        Task<Dish> UpdateAsync(Dish entity);
    }
}