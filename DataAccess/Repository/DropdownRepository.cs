using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.DataAccess.Repository.IRepository;

namespace AliceRestaurant.DataAccess.Repository
{
    public class DropdownRepository : BaseRepository<Dropdown>, IDropdownRepository
    {
        private readonly AppDbContext _db;
        public DropdownRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Dropdown> UpdateAsync(Dropdown entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.Dropdowns.Update(entity);

            // await _db.SaveChangesAsync();

            return entity;
        }

        public override async Task<Dropdown> CreateAsync(Dropdown entity)
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