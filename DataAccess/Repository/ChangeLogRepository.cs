using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.DataAccess.Repository
{
    public class ChangeLogRepository : Repository<ChangeLog>, IChangeLogRepository
    {
        private readonly AppDbContext _db;
        public ChangeLogRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<ChangeLog> CreateAsync(ChangeLog entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
            }
            return await base.CreateAsync(entity);
        }

        public async Task<IEnumerable<ChangeLog>> CreateRangeAsync(IEnumerable<ChangeLog> entities)
        {
            if (entities.Any())
            {
                await dbSet.AddRangeAsync(entities);
                await _db.SaveChangesAsync();
            }

            return entities;
        }

        public async Task<int> GetMaxChangeLogId()
        {
            return await dbSet.MaxAsync(x => x.ChangeLogId) ?? 0;
        }
    }
}