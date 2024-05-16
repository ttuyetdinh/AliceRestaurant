using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.DataAccess.Repository
{
    public class DeliveryCategoryRepository : BaseRepository<DeliveryCategory>, IDeliveryCategoryRepository
    {
        private readonly AppDbContext _db;
        public DeliveryCategoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<DeliveryCategory> UpdateAsync(DeliveryCategory entity)
        {
            try
            {
                entity.LastUpdated = DateTime.Now;
                _db.DeliveryCategories.Update(entity);

                // await _db.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DeliveryCategory> GetLastCategoryAsync()
        {
            return await _db.DeliveryCategories.OrderByDescending(u => u.DeliveryCategoryId).FirstOrDefaultAsync();
        }

        public override async Task<DeliveryCategory> CreateAsync(DeliveryCategory entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
                entity.LastUpdated = DateTime.Now;
            }
            return await base.CreateAsync(entity);
        }

        public override async Task<DeliveryCategory> RemoveAsync(DeliveryCategory entity)
        {
            try
            {
                var subCategories = await _db.DeliveryCategories
                    .Where(e => e.ParentCategoryId == entity.DeliveryCategoryId)
                    .ToListAsync();

                if (subCategories.Count > 0)
                {
                    foreach (var subCategory in subCategories)
                    {
                        subCategory.ParentCategoryId = null;
                    }
                }

                return await base.RemoveAsync(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}