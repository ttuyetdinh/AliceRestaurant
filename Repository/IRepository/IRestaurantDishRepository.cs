using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DishDTO;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IRestaurantDishRepository : IRepository<RestaurantDish>
    {
        Task<RestaurantDish> UpdateAsync(RestaurantDish entity);
        Task<IEnumerable<RestaurantDish>> CreateRangeAsync(int dishId, IEnumerable<int> restaurantIds);
        Task<IEnumerable<RestaurantDish>> UpdateRangeAsync(int dishId, IEnumerable<int> restaurantIds);

    }
}