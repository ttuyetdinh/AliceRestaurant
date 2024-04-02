using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DineInCategory;
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

        [HttpGet(nameof(GetAllCategories))]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                // this will get all the subcategories because the model is designed to be self referencing
                var categories = await _dineInRepo.GetAllAsync();
                var categoryDTOs = _mapper.Map<List<DineInCategoryDTO>>(categories);


                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = categoryDTOs
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet(nameof(GetCategory) + "/{id:int}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            try
            {
                var includeProperties = new List<string> { "ParentCategory", "DineInCategories" };
                var category = await _dineInRepo.GetAsync(e => e.DineInCategoryId == id, includeProperties: includeProperties);
                if (category == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Category not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var categoryDTO = _mapper.Map<DineInCategoryDTO>(category);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = categoryDTO
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