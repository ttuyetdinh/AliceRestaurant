using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DeliveryCategoryDTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceDelivery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryCategoriesController : ControllerBase
    {
        private readonly IDeliveryCategoryRepository _deliveryRepo;
        private readonly IMapper _mapper;

        public DeliveryCategoriesController(IDeliveryCategoryRepository deliveryRepo, IMapper mapper)
        {
            _deliveryRepo = deliveryRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                // this will get all the subcategories because the model is designed to be self referencing
                var categories = await _deliveryRepo.GetAllAsync();
                var categoryDTOs = _mapper.Map<List<DeliveryCategoryDTO>>(categories);


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
                var includeProperties = new List<string> { "ParentCategory", "DeliveryCategories" };
                var category = await _deliveryRepo.GetAsync(e => e.DeliveryCategoryId == id, includeProperties: includeProperties);
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
                var categoryDTO = _mapper.Map<DeliveryCategoryDTO>(category);

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
        public async Task<IActionResult> CreateCategory([FromBody] DeliveryCategoryCUDTO deliveryCatDTO)
        {
            try
            {
                var errors = new List<string>();
                if (deliveryCatDTO.ParentCategoryId != null)
                {
                    var lastCategory = await _deliveryRepo.GetLastCategoryAsync();
                    if (lastCategory.DeliveryCategoryId + 1 == deliveryCatDTO.ParentCategoryId)
                    {
                        return BadRequest(new ResponseDTO()
                        {
                            ErrorMessage = new List<string>() { "Parent category can't be the same with category" },
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.BadRequest
                        });
                    }

                    var parentCat = await _deliveryRepo.GetAsync(e => e.DeliveryCategoryId == deliveryCatDTO.ParentCategoryId);
                    if (parentCat == null)
                    {
                        return NotFound(new ResponseDTO()
                        {
                            ErrorMessage = new List<string>() { "Delivery parent category is not found." },
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.NotFound
                        });
                    }
                }

                var category = _mapper.Map<DeliveryCategory>(deliveryCatDTO);
                var response = await _deliveryRepo.CreateAsync(category);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DeliveryCategoryDTO>(category)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] DeliveryCategoryCUDTO deliveryCatDTO)
        {
            try
            {
                var errors = new List<string>();
                var category = await _deliveryRepo.GetAsync(e => e.DeliveryCategoryId == id);
                if (category == null)
                {
                    errors.Add("Delivery category is not found.");
                }

                if (deliveryCatDTO.ParentCategoryId != null)
                {
                    if (deliveryCatDTO.ParentCategoryId == id)
                    {
                        return BadRequest(new ResponseDTO()
                        {
                            ErrorMessage = new List<string>() { "Parent category can't be the same with category" },
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.BadRequest
                        });
                    }

                    var parentCat = await _deliveryRepo.GetAsync(e => e.DeliveryCategoryId == deliveryCatDTO.ParentCategoryId);
                    if (parentCat == null)
                    {
                        errors.Add("Delivery parent category is not found.");
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

                _mapper.Map(deliveryCatDTO, category);
                var response = await _deliveryRepo.UpdateAsync(category);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DeliveryCategoryDTO>(category)
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
                var category = await _deliveryRepo.GetAsync(e => e.DeliveryCategoryId == id);
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

                var response = await _deliveryRepo.RemoveAsync(category);

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