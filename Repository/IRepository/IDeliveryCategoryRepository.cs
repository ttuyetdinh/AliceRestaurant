using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data.Configuration;
using AliceRestaurant.Models;

namespace AliceRestaurant.Repository.IRepository
{
    public interface IDeliveryCategoryRepository : IRepository<DeliveryCategory>
    {
        Task<DeliveryCategory> UpdateAsync(DeliveryCategory entity);
        Task<DeliveryCategory> GetLastCategoryAsync();
    }
}