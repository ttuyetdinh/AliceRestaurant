using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Repository;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IDishRepository _dishRepo;
        private readonly IMapper _mapper;

        public DishController(IDishRepository dishRepo, IMapper mapper)
        {
            _dishRepo = dishRepo;
            _mapper = mapper;
        }

        [HttpGet(nameof(GetDishes))]
        public async Task<IActionResult> GetDishes()
        {
            try
            {
                var dishes = await _dishRepo.GetAllAsync();
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

        [HttpGet(nameof(GetDish) + "/{id:int}")]
        public async Task<IActionResult> GetDish(int id)
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