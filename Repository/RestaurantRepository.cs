using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;

namespace AliceRestaurant.Repository
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private readonly AppDbContext _db;
        public RestaurantRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Restaurant> UpdateAsync(Restaurant entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.Restaurants.Update(entity);

            await SaveAsync();

            return entity;
        }

        public override Task CreateAsync(Restaurant entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
                entity.LastUpdated = DateTime.Now;
            }
            return base.CreateAsync(entity);
        }
    }
}