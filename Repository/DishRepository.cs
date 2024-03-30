using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;

namespace AliceRestaurant.Repository
{
    public class DishRepository : Repository<Dish>, IDishRepository
    {
        private readonly AppDbContext _db;
        public DishRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Dish> UpdateAsync(Dish entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.Dishes.Update(entity);

            await SaveAsync();

            return entity;
        }

        public override Task CreateAsync(Dish entity)
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