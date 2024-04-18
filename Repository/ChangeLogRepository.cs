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
    }
}