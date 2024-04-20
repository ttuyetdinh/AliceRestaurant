using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.RestaurantDTO;
using AliceRestaurant.DataAccess.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    /// <summary>
    /// Controller for managing restaurant-related operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepo;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantsController"/> class.
        /// </summary>
        /// <param name="restaurantRepo">The restaurant repository.</param>
        /// <param name="mapper">The mapper.</param>
        /// <param name="dishRepo">The dish repository.</param>
        public RestaurantsController(IRestaurantRepository restaurantRepo, IMapper mapper)
        {
            _restaurantRepo = restaurantRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves all restaurants.
        /// </summary>
        /// <returns>The list of restaurants.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRestaurants()
        {
            try
            {
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

        /// <summary>
        /// Retrieves a specific restaurant by its ID.
        /// </summary>
        /// <param name="id">The ID of the restaurant.</param>
        /// <returns>The restaurant.</returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRestaurant(int id)
        {
            try
            {
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

        /// <summary>
        /// Retrieves the dishes of a specific restaurant.
        /// </summary>
        /// <param name="id">The ID of the restaurant.</param>
        /// <param name="dineInType">The type of dine-in.</param>
        /// <param name="deliveryType">The type of delivery.</param>
        /// <returns>The list of dishes.</returns>
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
                var dishesDTO = _mapper.Map<List<RestaurantDishDTO>>(dishes);

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

        /// <summary>
        /// Creates a new restaurant.
        /// </summary>
        /// <param name="restaurantDTO">The restaurant data.</param>
        /// <returns>The created restaurant.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] RestaurantCreateUpdateDTO restaurantDTO)
        {
            try
            {
                var restaurant = _mapper.Map<Restaurant>(restaurantDTO);
                var response = await _restaurantRepo.CreateAsync(restaurant);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<RestaurantDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        /// <summary>
        /// Updates an existing restaurant.
        /// </summary>
        /// <param name="id">The ID of the restaurant to update.</param>
        /// <param name="restaurantDTO">The updated restaurant data.</param>
        /// <returns>The updated restaurant.</returns>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateRestaurant(int id, [FromBody] RestaurantCreateUpdateDTO restaurantDTO)
        {
            try
            {
                var restaurant = await _restaurantRepo.GetAsync(u => u.RestaurantId == id);
                if (restaurant == null)
                {
                    return NotFound(new ResponseDTO
                    {
                        ErrorMessage = new List<string>() { "Restaurant does not exist." },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                _mapper.Map(restaurantDTO, restaurant);
                var response = await _restaurantRepo.UpdateAsync(restaurant);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<RestaurantDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        /// <summary>
        /// Deletes a restaurant with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the restaurant to delete.</param>
        /// <returns>The deleted restaurant</returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            try
            {
                var restaurant = await _restaurantRepo.GetAsync(u => u.RestaurantId == id);
                if (restaurant == null)
                {
                    return NotFound(new ResponseDTO
                    {
                        ErrorMessage = new List<string>() { "Restaurant does not exist." },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                var response = await _restaurantRepo.RemoveAsync(restaurant);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<RestaurantDTO>(response)
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