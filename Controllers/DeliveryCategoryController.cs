using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DeliveryCategory;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceDelivery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryCategoryController : ControllerBase
    {
        private readonly IDeliveryCategoryRepository _deliveryRepo;
        private readonly IMapper _mapper;

        public DeliveryCategoryController(IDeliveryCategoryRepository deliveryRepo, IMapper mapper)
        {
            _deliveryRepo = deliveryRepo;
            _mapper = mapper;
        }

        [HttpGet(nameof(GetAllCategories))]
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

        [HttpGet(nameof(GetCategory) + "/{id:int}")]
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