using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Repository
{
    public class DishHistoryRepository : Repository<DishHistory>, IDishHistoryRepository
    {
        private readonly AppDbContext _db;
        public DishHistoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<DishHistory> UpdateAsync(DishHistory entity)
        {
            try
            {
                entity.LastUpdated = DateTime.Now;
                _db.DishHistories.Update(entity);

                await _db.SaveChangesAsync();

                return entity;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public override async Task<DishHistory> CreateAsync(DishHistory entity)
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