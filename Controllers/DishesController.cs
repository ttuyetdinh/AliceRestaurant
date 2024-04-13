using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DishDTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepo;
        private readonly IDineInCategoryRepository _dineInCatRepo;
        private readonly IDeliveryCategoryRepository _deliveryCatRepo;
        private readonly IRestaurantRepository _restaurantRepo;
        private readonly IRestaurantDishRepository _restaurantDishRepo;
        private readonly IMapper _mapper;

        public DishesController(IDishRepository dishRepo, IMapper mapper, IDineInCategoryRepository dineInCatRepo, IDeliveryCategoryRepository deliveryCatRepo, IRestaurantRepository restaurantRepo, IRestaurantDishRepository restaurantDishRepo)
        {
            _dishRepo = dishRepo;
            _mapper = mapper;
            _dineInCatRepo = dineInCatRepo;
            _deliveryCatRepo = deliveryCatRepo;
            _restaurantRepo = restaurantRepo;
            _restaurantDishRepo = restaurantDishRepo;
        }


        [HttpGet]
        public async Task<IActionResult> GetDishes(
            [FromQuery] string dineInType = null,
            [FromQuery] string deliveryType = null,
            [FromQuery] string restaurantId = null,
            [FromQuery] string dineInCatId = null,
            [FromQuery] string deliveryCatId = null)
        {
            try
            {
                var include = new List<string> { "DineInCategory", "DeliveryCategory", "RestaurantDishes" };

                Expression<Func<Dish, bool>> filter = e =>
                    (string.IsNullOrEmpty(dineInType) || e.DineInType.ToLower().Equals(dineInType.ToLower()))
                    && (string.IsNullOrEmpty(deliveryType) || e.DeliveryType.ToLower().Equals(deliveryType.ToLower()))
                    && (string.IsNullOrEmpty(restaurantId) || e.RestaurantDishes.Any(rd => rd.RestaurantId == int.Parse(restaurantId)))
                    && (string.IsNullOrEmpty(dineInCatId) || e.DineInCategoryId == int.Parse(dineInCatId))
                    && (string.IsNullOrEmpty(deliveryCatId) || e.DeliveryCategoryId == int.Parse(deliveryCatId));

                var dishes = await _dishRepo.GetAllAsync(filter: filter, includeProperties: include);
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


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDish(int id)
        {
            try
            {
                var include = new List<string> { "DineInCategory", "DeliveryCategory", "RestaurantDishes" };
                var dish = await _dishRepo.GetAsync(e => e.DishId == id, includeProperties: include);
                if (dish == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Dish not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var dishDTO = _mapper.Map<DishDTO>(dish);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = dishDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet("{id:int}/restaurants")]
        public async Task<IActionResult> GetDishRestaurants(int id)
        {
            try
            {
                var include = new List<string> { "Restaurant" };

                var dishes = await _dishRepo.GetDishRestaurantsAsync(
                    e => e.DishId == id,
                    rdFilter: null,
                    tracked: false,
                    includeProperties: null);

                if (dishes == null)
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
                var dishesDTO = _mapper.Map<List<DishRestaurantDTO>>(dishes);

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

        [HttpPost]
        public async Task<IActionResult> CreateDish([FromBody] DishCreateDTO dishDTO)
        {
            try
            {
                List<string> errors = new List<string>();
                if (dishDTO.DineInCategoryId != null)
                {
                    var dineinCat = await _dineInCatRepo.GetAsync(e => e.DineInCategoryId == dishDTO.DineInCategoryId);
                    if (dineinCat == null)
                    {
                        errors.Add("DineIn category is not found.");
                    }
                }

                if (dishDTO.DeliveryCategoryId != null)
                {
                    var deliveryCat = await _deliveryCatRepo.GetAsync(e => e.DeliveryCategoryId == dishDTO.DeliveryCategoryId);
                    if (deliveryCat == null)
                    {
                        errors.Add("Delivery category is not found.");
                    }
                }

                if (errors.Count > 0)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = errors,
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                var dish = _mapper.Map<Dish>(dishDTO);
                var response = await _dishRepo.CreateAsync(dish);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DishDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpPost("{id:int}/restaurants")]
        public async Task<IActionResult> CreateDishRestaurants(int id, [FromBody] List<int> restaurantIds)
        {
            try
            {
                var dish = await _dishRepo.GetAsync(e => e.DishId == id);
                if (dish == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Dish not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                // check whether the restaurantIDs are all valid
                var restaurants = await _restaurantRepo.GetAllAsync(e => restaurantIds.Contains(e.RestaurantId), tracked: false);
                if (restaurantIds.Count != restaurants.Count())
                {
                    return BadRequest(ErrorResponse(customEx: "One or more restaurant IDs are invalid."));
                }

                var restaurantDishes = await _restaurantDishRepo.GetAllAsync(e => e.DishId == id && restaurantIds.Contains(e.RestaurantId));
                if (restaurantDishes.Count() > 0)
                {
                    return BadRequest(ErrorResponse(customEx: "One or more restaurant IDs already exist for the dish."));
                }


                var response = await _restaurantDishRepo.CreateRangeAsync(id, restaurantIds);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<List<DishRestaurantDTO>>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDish(int id, [FromBody] DishUpdateDTO dishDTO)
        {
            try
            {
                List<string> errors = new List<string>();
                if (dishDTO.DineInCategoryId != null)
                {
                    var dineinCat = await _dineInCatRepo.GetAsync(e => e.DineInCategoryId == dishDTO.DineInCategoryId);
                    if (dineinCat == null)
                    {
                        errors.Add("DineIn category is not found.");
                    }
                }

                if (dishDTO.DeliveryCategoryId != null)
                {
                    var deliveryCat = await _deliveryCatRepo.GetAsync(e => e.DeliveryCategoryId == dishDTO.DeliveryCategoryId);
                    if (deliveryCat == null)
                    {
                        errors.Add("Delivery category is not found.");
                    }
                }

                if (errors.Count > 0)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = errors,
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }


                var dish = await _dishRepo.GetAsync(e => e.DishId == id);
                if (dish == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Dish not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                _mapper.Map(dishDTO, dish);
                var response = await _dishRepo.UpdateAsync(dish);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DishDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDish(int id)
        {
            try
            {
                var dish = await _dishRepo.GetAsync(e => e.DishId == id);
                if (dish == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Dish not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                var response = await _dishRepo.RemoveAsync(dish);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DishDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        // ultilities methods

        /// <summary>
        /// Creates an error response for an exception.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="customEx">Custom error message.</param>
        /// <returns>The error response.</returns>
        private ResponseDTO ErrorResponse(Exception ex = null, string customEx = null)
        {
            return new ResponseDTO
            {
                ErrorMessage = new List<string>() {
                    customEx ?? "An error occurred while processing your request.",
                    ex == null ? null: ex.InnerException != null ? ex.InnerException.Message : ex.Message
                },
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest
            };
        }
    }
}