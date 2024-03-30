using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;

namespace AliceRestaurant.Repository
{
    public class DineInMenuRepository : Repository<DineInMenu>, IDineInMenuRepository
    {
        private readonly AppDbContext _db;
        public DineInMenuRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<DineInMenu> UpdateAsync(DineInMenu entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.DineInMenus.Update(entity);

            await SaveAsync();

            return entity;
        }

        public override Task CreateAsync(DineInMenu entity)
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