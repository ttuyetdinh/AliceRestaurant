using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Repository
{
    public class RestaurantDishRepository : Repository<RestaurantDish>, IRestaurantDishRepository
    {
        private readonly AppDbContext _db;
        public RestaurantDishRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<RestaurantDish> UpdateAsync(RestaurantDish entity)
        {
            entity.LastUpdated = DateTime.Now;
            dbSet.Update(entity);

            await _db.SaveChangesAsync();

            return entity;
        }

        public override async Task<RestaurantDish> CreateAsync(RestaurantDish entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
                entity.LastUpdated = DateTime.Now;
            }
            return await base.CreateAsync(entity);
        }

        public async Task<IEnumerable<RestaurantDish>> UpdateRangeAsync(int dishId, IEnumerable<int> restaurantIds)
        {
            // Get all the restaurant dishes for the dish
            var existingRestaurantDishes = await dbSet.Where(x => x.DishId == dishId).ToListAsync();
            var currentTime = DateTime.Now;

            // Find the restaurant dishes to delete
            var toDelete = existingRestaurantDishes.Where(x => !restaurantIds.Contains(x.RestaurantId)).ToList();

            // Create new restaurantDishes
            var newRestaurantDishes = restaurantIds
                .Except(existingRestaurantDishes.Select(x => x.RestaurantId))
                .Select(resId => new RestaurantDish
                {
                    DishId = dishId,
                    RestaurantId = resId,
                    CreatedOn = currentTime,
                    LastUpdated = currentTime
                }).ToList();

            if (toDelete.Any())
            {
                dbSet.RemoveRange(toDelete);
            }

            if (newRestaurantDishes.Any())
            {
                await dbSet.AddRangeAsync(newRestaurantDishes);
            }

            if (toDelete.Any() || newRestaurantDishes.Any())
            {
                await _db.SaveChangesAsync();
            }

            return existingRestaurantDishes.Except(toDelete).Concat(newRestaurantDishes);
        }
        public async Task<IEnumerable<RestaurantDish>> CreateRangeAsync(int dishId, IEnumerable<int> restaurantIds)
        {
            var currentTime = DateTime.Now;
            var restaurantDishes = restaurantIds
                .Select(resId => new RestaurantDish
                {
                    DishId = dishId,
                    RestaurantId = resId,
                    CreatedOn = currentTime,
                    LastUpdated = currentTime
                }).ToList();

            if (restaurantDishes.Any())
            {
                await dbSet.AddRangeAsync(restaurantDishes);
                await _db.SaveChangesAsync();
            }

            return restaurantDishes;
        }
    }
}