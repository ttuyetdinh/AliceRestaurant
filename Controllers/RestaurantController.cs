using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.RestaurantDTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepo;
        private readonly IMapper _mapper;

        public RestaurantController(IRestaurantRepository restaurantRepo, IMapper mapper)
        {
            _restaurantRepo = restaurantRepo;
            _mapper = mapper;
        }

        [HttpGet(nameof(GetRestaurants))]
        public async Task<IActionResult> GetRestaurants()
        {
            try
            {
                var include = new List<string> { "RestaurantDishes" };
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

        [HttpGet(nameof(GetRestaurant) + "/{id:int}")]
        public async Task<IActionResult> GetRestaurant(int id)
        {
            try
            {
                var include = new List<string> { "RestaurantDishes" };
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