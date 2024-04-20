using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Models;

namespace AliceRestaurant.DataAccess.Repository.IRepository
{
    public interface IChangeLogRepository : IBaseRepository<ChangeLog>
    {
        // Task<ChangeLog> UpdateAsync(ChangeLog entity);
        Task<IEnumerable<ChangeLog>> CreateRangeAsync(IEnumerable<ChangeLog> entities);
        Task<int> GetMaxChangeLogId();
    }
}