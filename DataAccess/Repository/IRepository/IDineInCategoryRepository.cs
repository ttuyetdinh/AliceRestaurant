using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.DataAccess.Repository.IRepository
{
    public interface IDineInCategoryRepository : IBaseRepository<DineInCategory>
    {
        Task<DineInCategory> UpdateAsync(DineInCategory entity);
        Task<DineInCategory> GetLastCategoryAsync();
    }
}