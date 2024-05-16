using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.DataAccess.Repository;
using AliceRestaurant.DataAccess.Repository.IRepository;
using AliceRestaurant.DataAccess.UnitOfWork.IUnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace AliceRestaurant.DataAccess.UnitOfWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly IServiceProvider _serviceProvider;
        private IDbContextTransaction? _currTransaction;
        private readonly AppDbContext _db;
        private bool _disposed = false;

        public UnitofWork(AppDbContext db, IServiceProvider serviceProvider)
        {
            _db = db;
            _serviceProvider = serviceProvider;
        }

        public async Task SaveAsync()
        {
            await _db.Database.CreateExecutionStrategy().ExecuteAsync(async () =>
            {
                await _db.SaveChangesAsync();
            });
        }

        public async Task CommitAsync()
        {
            if (_currTransaction is null) throw new InvalidOperationException("No transaction has been started.");

            try
            {
                await _db.Database.CreateExecutionStrategy().ExecuteInTransactionAsync(async () =>
                {
                    await _db.SaveChangesAsync();
                    _currTransaction?.Commit();
                });
            }
            catch (Exception)
            {
                await RollbackAsync();
                throw;
            }
            finally
            {
                _currTransaction?.Dispose();
                _currTransaction = null;
            }
        }

        public async Task BeginTransactionAsync()
        {
            if (_currTransaction is not null)
                throw new InvalidOperationException("A transaction has already been started.");
            _currTransaction = await _db.Database.BeginTransactionAsync();
        }
        public async Task RollbackAsync()
        {
            try
            {
                if (_currTransaction is null)
                    throw new InvalidOperationException("No transaction has been started.");
                await _currTransaction!.RollbackAsync();
            }
            finally
            {
                _currTransaction?.Dispose();
                _currTransaction = null;
            }

        }

        public T Repository<T>() where T : class
        {
            return _serviceProvider.GetService<T>();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }
    }
}