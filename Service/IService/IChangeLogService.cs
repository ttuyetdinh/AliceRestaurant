using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AliceRestaurant.Ultilities.SD;

namespace AliceRestaurant.Service.IService
{
    public interface IChangeLogService<T>
    {
        Task<bool> RecordChangeLog(T oldEntity, T newEntity, DbAction action);
    }
}