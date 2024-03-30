using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IDineInMenuRepository : IRepository<DineInMenu>
    {
        Task<DineInMenu> UpdateAsync(DineInMenu entity);
    }
}