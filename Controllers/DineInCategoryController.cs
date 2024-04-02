using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DineInCategoryController : ControllerBase
    {
        private readonly IDineInCategoryRepository _dineInRepo;
        private readonly IMapper _mapper;

        public DineInCategoryController(IDineInCategoryRepository dineInRepo, IMapper mapper)
        {
            _dineInRepo = dineInRepo;
            _mapper = mapper;
        }

        [HttpGet(nameof(GetDineInCategoryes))]
        public async Task<IActionResult> GetDineInCategoryes()
        {
            try
            {
                var dineInes = await _dineInRepo.GetAllAsync();
                var dineInesDTO = _mapper.Map<List<DineInCategoryDTO>>(dineInes);


                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = dineInesDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet(nameof(GetDineInCategory) + "/{id:int}")]
        public async Task<IActionResult> GetDineInCategory(int id)
        {
            try
            {
                var dineIn = await _dineInRepo.GetAsync(e => e.DineInCategoryId == id);
                if (dineIn == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "DineInCategory not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var dineInDTO = _mapper.Map<DineInCategoryDTO>(dineIn);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = dineInDTO
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