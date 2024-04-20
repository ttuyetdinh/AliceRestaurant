using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DineInCategoryDTO;
using AliceRestaurant.DataAccess.Repository.IRepository;
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

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] DineInCategoryCUDTO dineInCatDTO)
        {
            try
            {
                var errors = new List<string>();
                if (dineInCatDTO.ParentCategoryId != null)
                {
                    var lastCategory = await _dineInRepo.GetLastCategoryAsync();
                    if (lastCategory.DineInCategoryId + 1 == dineInCatDTO.ParentCategoryId)
                    {
                        return BadRequest(new ResponseDTO()
                        {
                            ErrorMessage = new List<string>() { "Parent category can't be the same with category" },
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.BadRequest
                        });
                    }

                    var parentCat = await _dineInRepo.GetAsync(e => e.DineInCategoryId == dineInCatDTO.ParentCategoryId);
                    if (parentCat == null)
                    {
                        return NotFound(new ResponseDTO()
                        {
                            ErrorMessage = new List<string>() { "DineIn parent category is not found." },
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.NotFound
                        });
                    }
                }

                var category = _mapper.Map<DineInCategory>(dineInCatDTO);
                var response = await _dineInRepo.CreateAsync(category);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DineInCategoryDTO>(category)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] DineInCategoryCUDTO dineInCatDTO)
        {
            try
            {
                var errors = new List<string>();
                var category = await _dineInRepo.GetAsync(e => e.DineInCategoryId == id);
                if (category == null)
                {
                    errors.Add("DineIn category is not found.");
                }

                if (dineInCatDTO.ParentCategoryId != null)
                {
                    if (dineInCatDTO.ParentCategoryId == id)
                    {
                        return BadRequest(new ResponseDTO()
                        {
                            ErrorMessage = new List<string>() { "Parent category can't be the same with category" },
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.BadRequest
                        });
                    }

                    var parentCat = await _dineInRepo.GetAsync(e => e.DineInCategoryId == dineInCatDTO.ParentCategoryId);
                    if (parentCat == null)
                    {
                        errors.Add("DineIn parent category is not found.");
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

                _mapper.Map(dineInCatDTO, category);
                var response = await _dineInRepo.UpdateAsync(category);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DineInCategoryDTO>(category)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var category = await _dineInRepo.GetAsync(e => e.DineInCategoryId == id);
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

                var response = await _dineInRepo.RemoveAsync(category);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = category
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