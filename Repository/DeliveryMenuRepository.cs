using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;

namespace AliceRestaurant.Repository
{
    public class DeliveryMenuRepository : Repository<DeliveryMenu>, IDeliveryMenuRepository
    {
        private readonly AppDbContext _db;
        public DeliveryMenuRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<DeliveryMenu> UpdateAsync(DeliveryMenu entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.DeliveryMenus.Update(entity);

            await SaveAsync();

            return entity;
        }

        public override Task CreateAsync(DeliveryMenu entity)
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