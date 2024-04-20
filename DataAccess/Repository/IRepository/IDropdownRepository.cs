using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.DataAccess.Repository.IRepository
{
    public interface IDropdownRepository : IRepository<Dropdown>
    {
        Task<Dropdown> UpdateAsync(Dropdown entity);
    }
}