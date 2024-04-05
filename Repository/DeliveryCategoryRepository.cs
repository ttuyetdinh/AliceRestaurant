using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;

namespace AliceRestaurant.Repository
{
    public class DeliveryCategoryRepository : Repository<DeliveryCategory>, IDeliveryCategoryRepository
    {
        private readonly AppDbContext _db;
        public DeliveryCategoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<DeliveryCategory> UpdateAsync(DeliveryCategory entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.DeliveryCategories.Update(entity);

            await _db.SaveChangesAsync();

            return entity;
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
    }
}