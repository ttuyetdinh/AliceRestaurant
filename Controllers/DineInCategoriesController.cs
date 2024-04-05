using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DineInCategoryDTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/dinein-categories")]
    public class DineInCategoriesController : ControllerBase
    {
        private readonly IDineInCategoryRepository _dineInRepo;
        private readonly IMapper _mapper;

        public DineInCategoriesController(IDineInCategoryRepository dineInRepo, IMapper mapper)
        {
            _dineInRepo = dineInRepo;
            _mapper = mapper;
        }

        [HttpGet]
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

        [HttpGet("{id:int}")]
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

        // [HttpPost]
        // public async Task<IActionResult> CreateCategory([FromBody] DineInCategoryCUDTO categoryDTO)
        // {
        //     try
        //     {
        //         if (categoryDTO == null)
        //         {
        //             return BadRequest(new ResponseDTO()
        //             {
        //                 ErrorMessage = new List<string>() {
        //                     "Category object is null."
        //                 },
        //                 IsSuccess = false,
        //                 StatusCode = HttpStatusCode.BadRequest
        //             });
        //         }

        //         if (!ModelState.IsValid)
        //         {
        //             return BadRequest(new ResponseDTO()
        //             {
        //                 ErrorMessage = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage)).ToList(),
        //                 IsSuccess = false,
        //                 StatusCode = HttpStatusCode.BadRequest
        //             });
        //         }

        //         var category = _mapper.Map<DineInCategory>(categoryDTO);
        //         var isSuccess = await _dineInRepo.AddAsync(category);
        //         if (!isSuccess)
        //         {
        //             return BadRequest(new ResponseDTO()
        //             {
        //                 ErrorMessage = new List<string>() {
        //                     "An error occurred while processing your request."
        //                 },
        //                 IsSuccess = false,
        //                 StatusCode = HttpStatusCode.BadRequest
        //             });
        //         }

        //         return Ok(new ResponseDTO()
        //         {
        //             StatusCode = HttpStatusCode.OK,
        //             IsSuccess = true,
        //             Result = category
        //         });
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(ErrorResponse(ex));
        //     }
        // }

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