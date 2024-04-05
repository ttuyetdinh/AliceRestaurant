using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IDineInCategoryRepository : IRepository<DineInCategory>
    {
        Task<DineInCategory> UpdateAsync(DineInCategory entity);
        Task<DineInCategory> GetLastCategoryAsync();
    }
}