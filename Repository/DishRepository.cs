using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AliceRestaurant.Data;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DishDTO;
using AliceRestaurant.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Repository
{
    public class DishRepository : Repository<Dish>, IDishRepository
    {
        private readonly AppDbContext _db;
        public DishRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Dish> UpdateAsync(Dish entity)
        {
            try
            {
                entity.LastUpdated = DateTime.Now;
                _db.Dishes.Update(entity);

                await _db.SaveChangesAsync();

                return entity;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public override async Task<Dish> CreateAsync(Dish entity)
        {
            if (entity.CreatedOn == default)
            {
                entity.CreatedOn = DateTime.Now;
                entity.LastUpdated = DateTime.Now;
            }
            return await base.CreateAsync(entity);
        }

        public override async Task<List<Dish>> GetAllAsync(Expression<Func<Dish, bool>>? filter = null, List<string>? includeProperties = null, Pagination? pagination = null, bool tracked = true)
        {
            try
            {
                IQueryable<Dish> query = dbSet;
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
                            query = query.Include(x => x.RestaurantDishes).ThenInclude(x => x.Restaurant);
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

        public virtual async Task<Dish> GetAsync(Expression<Func<Dish, bool>>? filter = null, bool tracked = true, List<string>? includeProperties = null)
        {
            try
            {
                IQueryable<Dish> query = dbSet;

                query = !tracked ? query.AsNoTracking() : query;

                query = filter != null ? query.Where(filter) : query;

                if (includeProperties != null)
                {
                    foreach (var property in includeProperties)
                    {
                        if (property == "RestaurantDishes")
                        {
                            query = query.Include(x => x.RestaurantDishes).ThenInclude(x => x.Restaurant);
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

        public async Task<List<Restaurant>> GetDishRestaurantsAsync(
            Expression<Func<Dish, bool>>? dishFilter = null,
            Expression<Func<RestaurantDish, bool>>? rdFilter = null,
            bool tracked = true, List<string>? includeProperties = null)
        {
            try
            {
                int dishId = await GetDishId(dishFilter);
                if (dishId == 0)
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
                        query = query.Include($"Restaurant.{property}");
                    }
                }

                var restaurants = await query.Where(e => e.DishId == dishId)
                                .Select(e => e.Restaurant)
                                .ToListAsync();
                return restaurants;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // helper method
        private async Task<int> GetDishId(Expression<Func<Dish, bool>>? filter = null)
        {
            try
            {
                IQueryable<Dish> resQuery = dbSet;

                resQuery = filter != null ? resQuery.Where(filter) : resQuery;

                var dish = await resQuery.FirstOrDefaultAsync();
                return dish?.DishId ?? 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}