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
    /// <summary>
    /// Controller for managing dropdowns.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DropdownsController : ControllerBase
    {
        private readonly IDropdownRepository _dropdownRepo;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownsController"/> class.
        /// </summary>
        /// <param name="dropdownRepo">The dropdown repository.</param>
        /// <param name="mapper">The mapper.</param>
        public DropdownsController(IDropdownRepository dropdownRepo, IMapper mapper)
        {
            _dropdownRepo = dropdownRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets the dropdowns based on the specified module and type.
        /// </summary>
        /// <param name="module">The module name.</param>
        /// <param name="type">The dropdown type.</param>
        /// <returns>The list of dropdowns.</returns>
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

        /// <summary>
        /// Gets the dropdown with the specified ID.
        /// </summary>
        /// <param name="id">The dropdown ID.</param>
        /// <returns>The dropdown.</returns>
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

        /// <summary>
        /// Creates a new dropdown.
        /// </summary>
        /// <param name="dropdownDTO">The dropdown data.</param>
        /// <returns>The created dropdown.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateDropdown([FromBody] DropdownCreateDTO dropdownDTO)
        {
            try
            {
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

        /// <summary>
        /// Updates the dropdown with the specified ID.
        /// </summary>
        /// <param name="id">The dropdown ID.</param>
        /// <param name="dropdownDTO">The updated dropdown data.</param>
        /// <returns>The updated dropdown.</returns>
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

        /// <summary>
        /// Deletes the dropdown with the specified ID.
        /// </summary>
        /// <param name="id">The dropdown ID.</param>
        /// <returns>The deleted dropdown.</returns>
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

        /// <summary>
        /// Creates an error response for the specified exception.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <returns>The error response.</returns>
        private ResponseDTO ErrorResponse(Exception ex = null, string customEx = null)
        {
            return new ResponseDTO
            {
                ErrorMessage = new List<string>() {
                    customEx ?? "An error occurred while processing your request.",
                    ex == null ? null: ex.InnerException != null ? ex.InnerException.Message : ex.Message
                },
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest
            };
        }
    }
}