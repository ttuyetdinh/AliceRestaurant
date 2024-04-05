using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Repository
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private readonly AppDbContext _db;
        public RestaurantRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Restaurant> UpdateAsync(Restaurant entity)
        {
            entity.LastUpdated = DateTime.Now;
            _db.Restaurants.Update(entity);

            await _db.SaveChangesAsync();

            return entity;
        }

        public override async Task<Restaurant> CreateAsync(Restaurant entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
                entity.LastUpdated = DateTime.Now;
            }
            return await base.CreateAsync(entity);
        }

        public override async Task<List<Restaurant>> GetAllAsync(Expression<Func<Restaurant, bool>>? filter = null, List<string>? includeProperties = null, Pagination? pagination = null, bool tracked = true)
        {
            try
            {
                IQueryable<Restaurant> query = dbSet;
                int pageSize = pagination?.PageSize ?? 0;
                int pageNum = pagination?.PageNum ?? 0;

                query = !tracked ? query.AsNoTracking() : query;

                query = filter != null ? query.Where(filter) : query;

                if (pageSize > 0 && pageNum > 0)
                {
                    pageSize = pageSize > 100 ? 100 : pageSize;
                    query = query.Skip((pageNum - 1) * pageSize).Take(pageSize);
                }
                // include properties have relationship with the entity
                if (includeProperties != null)
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        if (includeProperty == "RestaurantDishes")
                        {
                            // For dine-in
                            query = query.Include(x => x.RestaurantDishes)
                                        .ThenInclude(x => x.Dish)
                                        .ThenInclude(x => x.DineInCategory);
                            // For delivery
                            query = query.Include(x => x.RestaurantDishes)
                                        .ThenInclude(x => x.Dish)
                                        .ThenInclude(x => x.DeliveryCategory);
                        }
                        else
                        {
                            query = query.Include(includeProperty);
                        }
                    }
                }
                return await query.ToListAsync();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public override async Task<Restaurant> GetAsync(Expression<Func<Restaurant, bool>>? filter = null, bool tracked = true, List<string>? includeProperties = null)
        {
            try
            {
                IQueryable<Restaurant> query = dbSet;

                query = !tracked ? query.AsNoTracking() : query;

                query = filter != null ? query.Where(filter) : query;

                if (includeProperties != null)
                {
                    foreach (var property in includeProperties)
                    {
                        if (property == "RestaurantDishes")
                        {
                            // For dine-in
                            query = query.Include(x => x.RestaurantDishes)
                                        .ThenInclude(x => x.Dish)
                                        .ThenInclude(x => x.DineInCategory);
                            // For delivery
                            query = query.Include(x => x.RestaurantDishes)
                                        .ThenInclude(x => x.Dish)
                                        .ThenInclude(x => x.DeliveryCategory);
                        }
                        else
                        {
                            query = query.Include(property);
                        }
                    };
                }

                return await query.FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Dish>> GetRestaurantDishesAsync(
            Expression<Func<Restaurant, bool>>? resFilter = null,
            Expression<Func<RestaurantDish, bool>>? rdFilter = null,
            bool tracked = true, List<string>? includeProperties = null)
        {
            try
            {
                int resId = await GetRestaurantId(resFilter);
                if (resId == 0)
                {
                    return null;
                }

                IQueryable<RestaurantDish> query = _db.RestaurantDishes;

                query = !tracked ? query.AsNoTracking() : query;

                query = rdFilter != null ? query.Where(rdFilter) : query;

                if (includeProperties != null)
                {
                    foreach (var property in includeProperties)
                    {
                        query = query.Include($"Dish.{property}");
                    }
                }

                var dishes = await query.Where(e => e.RestaurantId == resId)
                                .Select(e => e.Dish)
                                .ToListAsync();
                return dishes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // helper method
        private async Task<int> GetRestaurantId(Expression<Func<Restaurant, bool>>? resFilter = null)
        {
            try
            {
                IQueryable<Restaurant> resQuery = dbSet;

                resQuery = resFilter != null ? resQuery.Where(resFilter) : resQuery;

                var restaurant = await resQuery.FirstOrDefaultAsync();
                return restaurant?.RestaurantId ?? 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}