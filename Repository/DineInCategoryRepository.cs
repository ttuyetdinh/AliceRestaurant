using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;

namespace AliceRestaurant.Repository
{
    public class DineInCategoryRepository : Repository<DineInCategory>, IDineInCategoryRepository
    {
        private readonly AppDbContext _db;
        public DineInCategoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<DineInCategory> UpdateAsync(DineInCategory entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.DineInCategories.Update(entity);

            await SaveAsync();

            return entity;
        }

        public override async Task<DineInCategory> CreateAsync(DineInCategory entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
                entity.LastUpdated = DateTime.Now;
            }
            return await base.CreateAsync(entity);
        }
    }
}