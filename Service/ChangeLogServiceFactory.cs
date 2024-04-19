using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Service.IService;

namespace AliceRestaurant.Service
{
    public class ChangeLogServiceFactory : IChangeLogServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ChangeLogServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IChangeLogService<T> CreateService<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<IChangeLogService<T>>();
        }
    }
}