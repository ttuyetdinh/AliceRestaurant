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

namespace AliceDelivery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryMenuRepository _deliveryRepo;
        private readonly IMapper _mapper;

        public DeliveryController(IDeliveryMenuRepository deliveryRepo, IMapper mapper)
        {
            _deliveryRepo = deliveryRepo;
            _mapper = mapper;
        }

        [HttpGet(nameof(GetDeliveryes))]
        public async Task<IActionResult> GetDeliveryes()
        {
            try
            {
                var deliveryes = await _deliveryRepo.GetAllAsync();
                var deliveryesDTO = _mapper.Map<List<DeliveryMenuDTO>>(deliveryes);


                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = deliveryesDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet(nameof(GetDelivery) + "/{id:int}")]
        public async Task<IActionResult> GetDelivery(int id)
        {
            try
            {
                var delivery = await _deliveryRepo.GetAsync(e => e.DeliveryMenuId == id);
                if (delivery == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "Delivery not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var deliveryDTO = _mapper.Map<DeliveryMenuDTO>(delivery);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = deliveryDTO
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