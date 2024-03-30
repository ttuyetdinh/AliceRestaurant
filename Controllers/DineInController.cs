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
    public class DineInMenuController : ControllerBase
    {
        private readonly IDineInMenuRepository _dineInRepo;
        private readonly IMapper _mapper;

        public DineInMenuController(IDineInMenuRepository dineInRepo, IMapper mapper)
        {
            _dineInRepo = dineInRepo;
            _mapper = mapper;
        }

        [HttpGet(nameof(GetDineInMenues))]
        public async Task<IActionResult> GetDineInMenues()
        {
            try
            {
                var dineInes = await _dineInRepo.GetAllAsync();
                var dineInesDTO = _mapper.Map<List<DineInMenuDTO>>(dineInes);


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

        [HttpGet(nameof(GetDineInMenu) + "/{id:int}")]
        public async Task<IActionResult> GetDineInMenu(int id)
        {
            try
            {
                var dineIn = await _dineInRepo.GetAsync(e => e.DineInMenuId == id);
                if (dineIn == null)
                {
                    return NotFound(new ResponseDTO()
                    {
                        ErrorMessage = new List<string>() {
                            "DineInMenu not found."
                        },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }
                var dineInDTO = _mapper.Map<DineInMenuDTO>(dineIn);

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