using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using AliceRestaurant.Repository.IRepository;
using AliceRestaurant.Service.IService;
using Microsoft.EntityFrameworkCore;
using static AliceRestaurant.Ultilities.SD;
using AliceRestaurant.Models;
using System.ComponentModel.DataAnnotations;
using AliceRestaurant.Data;

namespace AliceRestaurant.Service
{
    public class ChangeLogService<T> : IChangeLogService<T> where T : class
    {
        private readonly IChangeLogRepository _changeLogRepo;
        private readonly AppDbContext _db;
        internal DbSet<T> dbSet;
        public ChangeLogService(IChangeLogRepository changeLogRepository, AppDbContext db)
        {
            _changeLogRepo = changeLogRepository;
            _db = db;
            dbSet = _db.Set<T>();
        }
        public async Task<bool> RecordChangeLog(T oldEntity, T newEntity, DbAction action)
        {

            try
            {
                string tableName = typeof(T).Name.Pluralize(inputIsKnownToBeSingular: false);
                string actionString = action.ToString();

                // todo: find the change and call repository to insert to db
                switch (action)
                {
                    case DbAction.Create:
                        // Perform actions for Create case
                        await _changeLogRepo.CreateAsync(new ChangeLog
                        {
                            RecordId = GetPrimaryKeyValue(newEntity),
                            TableName = tableName,
                            ColumnName = "All",
                            OldValue = null,
                            NewValue = null,
                            Action = actionString,
                            UserId = null,
                            CreatedOn = DateTime.Now,
                        });
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }



        // helper method
        private int GetPrimaryKeyValue<T>(T entity)
        {
            var type = typeof(T);
            var allProperties = type.GetProperties();
            var keyProperty = allProperties.FirstOrDefault(p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0);

            if (keyProperty == null)
            {
                throw new Exception("No Key attribute found on type " + type.Name);
            }

            return keyProperty.GetValue(entity) as int? ?? 0; // Safely cast the return value to int
        }
    }
}