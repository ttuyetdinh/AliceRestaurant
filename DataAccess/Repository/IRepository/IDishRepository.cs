using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DishDTO;

namespace AliceRestaurant.DataAccess.Repository.IRepository
{
    public interface IDishRepository : IRepository<Dish>
    {
        Task<Dish> UpdateAsync(Dish entity);
        Task<List<Restaurant>> GetDishRestaurantsAsync(
            Expression<Func<Dish, bool>>? dishFilter = null,
            Expression<Func<RestaurantDish, bool>>? rdFilter = null,
            bool tracked = true, List<string>? includeProperties = null);
    }
}