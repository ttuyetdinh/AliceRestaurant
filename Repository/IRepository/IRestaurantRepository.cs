using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<Restaurant> UpdateAsync(Restaurant entity);
        Task<List<Dish>> GetRestaurantDishesAsync(
            Expression<Func<Restaurant, bool>>? resFilter = null,
            Expression<Func<RestaurantDish, bool>>? rdFilter = null,
            bool tracked = true, List<string>? includeProperties = null);
    }
}