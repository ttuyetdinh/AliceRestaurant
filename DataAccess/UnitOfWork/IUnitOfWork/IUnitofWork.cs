using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.DataAccess.Repository.IRepository;

namespace AliceRestaurant.DataAccess.UnitOfWork.IUnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        T Repository<T>() where T : class;
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task SaveAsync();
    }
}