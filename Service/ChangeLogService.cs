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
using System.Collections;

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
                int changeLogId = await _changeLogRepo.GetMaxChangeLogId();

                // todo: find the change and call repository to insert to db
                switch (action)
                {
                    case DbAction.Create:
                        // Perform actions for Create case
                        await _changeLogRepo.CreateAsync(new ChangeLog
                        {
                            ChangeLogId = changeLogId + 1,
                            ChangeLogItem = 1,
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

                    case DbAction.Delete:
                        await _changeLogRepo.CreateAsync(new ChangeLog
                        {
                            ChangeLogId = changeLogId + 1,
                            ChangeLogItem = 1,
                            RecordId = GetPrimaryKeyValue(oldEntity),
                            TableName = tableName,
                            ColumnName = "All",
                            OldValue = null,
                            NewValue = null,
                            Action = actionString,
                            UserId = null,
                            CreatedOn = DateTime.Now,
                        });
                        break;

                    case DbAction.Update:
                        // Perform actions for Update case
                        var excludeFields = new List<string> { "LastUpdated", "CreatedOn" };
                        var entityProperties = GetDatabaseFields<T>(excludeFields);
                        var insertList = new List<ChangeLog>();

                        int changeLogItem = 1;
                        foreach (var property in entityProperties)
                        {
                            var oldValue = oldEntity.GetType().GetProperty(property)?.GetValue(oldEntity);
                            var newValue = newEntity.GetType().GetProperty(property)?.GetValue(newEntity);

                            if (oldValue == null && newValue == null)
                            {
                                continue;
                            }

                            if (oldValue == null || newValue == null || !oldValue.Equals(newValue))
                            {
                                insertList.Add(new ChangeLog
                                {
                                    ChangeLogId = changeLogId + 1,
                                    ChangeLogItem = changeLogItem++,
                                    RecordId = GetPrimaryKeyValue(oldEntity),
                                    TableName = tableName,
                                    ColumnName = property,
                                    OldValue = oldValue?.ToString(),
                                    NewValue = newValue?.ToString(),
                                    Action = actionString,
                                    UserId = null,
                                    CreatedOn = DateTime.Now,
                                });
                            }
                        }

                        await _changeLogRepo.CreateRangeAsync(insertList);
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

        private List<string> GetDatabaseFields<T>(List<string> excludeFields = null)
        {
            var entityType = _db.Model.FindEntityType(typeof(T));
            if (entityType == null)
            {
                return new List<string>();
            }

            var allProperties = entityType.GetProperties().Select(p => p.Name);
            var navigationProps = entityType.GetNavigations().Select(n => n.Name);
            var primaryKey = entityType.FindPrimaryKey().Properties.Select(p => p.Name);

            var databaseFields = allProperties.Except(navigationProps).Except(primaryKey);

            if (excludeFields != null)
            {
                databaseFields = databaseFields.Except(excludeFields);
            }

            return databaseFields.ToList();
        }
    }
}