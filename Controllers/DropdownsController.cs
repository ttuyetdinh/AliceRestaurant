using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DropdownDTO;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DropdownsController : ControllerBase
    {
        private readonly IDropdownRepository _dropdownRepo;
        private readonly IMapper _mapper;
        public DropdownsController(IDropdownRepository dropdownRepo, IMapper mapper)
        {
            _dropdownRepo = dropdownRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetDropdowns([FromQuery] string module = null, [FromQuery] string type = null)
        {
            try
            {
                var dropdowns = await _dropdownRepo.GetAllAsync(u =>
                                (string.IsNullOrEmpty(module) || u.Module.ToLower().Equals(module.ToLower()))
                                && (string.IsNullOrEmpty(type) || u.Type.ToLower().Equals(type.ToLower()))
                                && u.IsActive == true);

                var dropdownsDTO = _mapper.Map<List<DropdownDTO>>(dropdowns);

                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = dropdownsDTO
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDropdown(int id)
        {
            try
            {
                var dropdown = await _dropdownRepo.GetAsync(u => u.DropdownId == id);
                if (dropdown == null)
                {
                    return NotFound(new ResponseDTO
                    {
                        ErrorMessage = new List<string>() { "Dropdown is not exsit" },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                return Ok(new ResponseDTO
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DropdownDTO>(dropdown)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateDropdown([FromBody] DropdownCreateDTO dropdownDTO)
        {
            try
            {
                if (dropdownDTO == null)
                {
                    return BadRequest(new ResponseDTO
                    {
                        ErrorMessage = new List<string>() { "Dropdown object is null" },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.BadRequest
                    });
                }

                var dropdown = _mapper.Map<Dropdown>(dropdownDTO);
                var response = await _dropdownRepo.CreateAsync(dropdown);

                return Ok(new ResponseDTO
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DropdownDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDropdown(int id, [FromBody] DropdownUpdateDTO dropdownDTO)
        {
            try
            {
                var dropdown = await _dropdownRepo.GetAsync(u => u.DropdownId == id);
                if (dropdown == null)
                {
                    return NotFound(new ResponseDTO
                    {
                        ErrorMessage = new List<string>() { "Dropdown is not exsit" },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                _mapper.Map(dropdownDTO, dropdown);
                var response = await _dropdownRepo.UpdateAsync(dropdown);

                return Ok(new ResponseDTO
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = _mapper.Map<DropdownDTO>(response)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorResponse(ex));
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDropdown(int id)
        {
            try
            {
                var dropdown = await _dropdownRepo.GetAsync(u => u.DropdownId == id);
                if (dropdown == null)
                {
                    return NotFound(new ResponseDTO
                    {
                        ErrorMessage = new List<string>() { "Dropdown object is null" },
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound
                    });
                }

                await _dropdownRepo.RemoveAsync(dropdown);

                return Ok(new ResponseDTO
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = dropdown
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