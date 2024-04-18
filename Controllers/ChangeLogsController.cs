using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.ChangeLogDTO;
using AliceRestaurant.Models.DTO.DishDTO;
using AliceRestaurant.Repository.IRepository;
using AliceRestaurant.Service.IService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static AliceRestaurant.Ultilities.SD;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChangeLogsController : ControllerBase
    {
        private readonly IChangeLogRepository _changeLogRepo;
        private readonly IMapper _mapper;

        public ChangeLogsController(IChangeLogRepository changeLogRepo, IMapper mapper)
        {
            _changeLogRepo = changeLogRepo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetChangeLogs(
            [FromQuery] string recordId = null,
            [FromQuery] string tableName = null,
            [FromQuery] string action = null)
        {
            try
            {
                Expression<Func<ChangeLog, bool>> filter = e =>
                    (string.IsNullOrEmpty(recordId) || e.RecordId == int.Parse(recordId))
                    && (string.IsNullOrEmpty(tableName) || e.TableName.ToLower().Equals(tableName.ToLower()))
                    && (string.IsNullOrEmpty(action) || e.Action.ToLower().Equals(action.ToLower()));

                var changelogs = await _changeLogRepo.GetAllAsync(filter: filter);
                var changelogsDTO = _mapper.Map<List<ChangeLogDTO>>(changelogs);


                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = changelogsDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }


        // [HttpGet("{id:int}")]
        // public async Task<IActionResult> GetDish(int id)
        // {
        //     try
        //     {
        //         var include = new List<string> { "DineInCategory", "DeliveryCategory", "RestaurantDishes" };
        //         var dish = await _changeLogRepo.GetAsync(e => e.DishId == id, includeProperties: include);
        //         if (dish == null)
        //         {
        //             return NotFound(new ResponseDTO()
        //             {
        //                 ErrorMessage = new List<string>() {
        //                     "Dish not found."
        //                 },
        //                 IsSuccess = false,
        //                 StatusCode = HttpStatusCode.NotFound
        //             });
        //         }
        //         var dishDTO = _mapper.Map<DishDTO>(dish);

        //         return Ok(new ResponseDTO()
        //         {
        //             StatusCode = HttpStatusCode.OK,
        //             IsSuccess = true,
        //             Result = dishDTO
        //         });
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(ErrorResponse(ex));
        //     }
        // }

        // ultilities methods

        /// <summary>
        /// Creates an error response for an exception.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="customEx">Custom error message.</param>
        /// <returns>The error response.</returns>
        private ResponseDTO ErrorResponse(Exception ex = null, string customEx = null, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            List<string> errors = customEx.Split("|").ToList();
            if (ex != null)
            {
                errors.Add(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }

            return new ResponseDTO
            {
                ErrorMessage = errors,
                IsSuccess = false,
                StatusCode = statusCode
            };
        }
    }
}