using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.Dish;
using AliceRestaurant.Models.DTO.RestaurantDTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepo;
        private readonly IDishRepository _dishRepo;
        private readonly IMapper _mapper;

        public RestaurantsController(IRestaurantRepository restaurantRepo, IMapper mapper, IDishRepository dishRepo)
        {
            _restaurantRepo = restaurantRepo;
            _mapper = mapper;
            _dishRepo = dishRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetRestaurants()
        {
            try
            {
                // var include = new List<string> { "RestaurantDishes" };
                var include = new List<string> { };
                var restaurants = await _restaurantRepo.GetAllAsync(includeProperties: include);
                var restaurantsDTO = _mapper.Map<List<RestaurantDTO>>(restaurants);


                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = restaurantsDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRestaurant(int id)
        {
            try
            {
                // var include = new List<string> { "RestaurantDishes" };
                var include = new List<string> { };
                var restaurant = await _restaurantRepo.GetAsync(e => e.RestaurantId == id, includeProperties: include);
                if (restaurant == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Restaurant not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var restaurantDTO = _mapper.Map<RestaurantDTO>(restaurant);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = restaurantDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet("{id:int}/dishes")]
        public async Task<IActionResult> GetRestaurantDishes(int id, [FromQuery] string dineInType = null, [FromQuery] string deliveryType = null)
        {
            try
            {
                var include = new List<string> { "DineInCategory", "DeliveryCategory" };
                Expression<Func<RestaurantDish, bool>> rdFilter = u =>
                                (string.IsNullOrEmpty(dineInType) || u.Dish.DineInType.ToLower().Equals(dineInType.ToLower()))
                                && (string.IsNullOrEmpty(deliveryType) || u.Dish.DeliveryType.ToLower().Equals(deliveryType.ToLower()));

                var dishes = await _restaurantRepo.GetRestaurantDishesAsync(
                        e => e.RestaurantId == id,
                        rdFilter: rdFilter,
                        tracked: false,
                        includeProperties: include);
                if (dishes == null || dishes.Count == 0)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Dishes not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var dishesDTO = _mapper.Map<List<DishDTO>>(dishes);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = dishesDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        // ultilities methos
        private ResponseDTO ErrorResponse(Exception ex)
        {
            return new ResponseDTO
            {
                ErrorMessage = new List<string>() {
                    "An error occurred while processing your request.",
                    ex.InnerException != null ? ex.InnerException.Message : ex.Message
                },
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest
            };
        }
    }
}