using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AliceRestaurant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiHelperController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ApiHelperController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("ApiDocument")]
        public IActionResult ApiDocument()
        {
            try
            {
                string apiUrl = _config.GetValue<string>("ApiUrl") ?? "";
                var result = new
                {
                    DeliveryCategory = new
                    {
                        GetAllCategories = new
                        {
                            Url = $"{apiUrl}/api/DeliveryCategory/GetAllCategories",
                            Method = "GET",
                            Description = "Get all delivery categories",
                            Param = "None"
                        },
                        GetCategory = new
                        {
                            Url = $"{apiUrl}/api/DeliveryCategory/GetCategory/{{id}}",
                            Method = "GET",
                            Description = "Get a delivery category by id",
                            Param = "id: int"
                        }
                    },
                    DineInCategory = new
                    {
                        GetAllCategories = new
                        {
                            Url = $"{apiUrl}/api/DineInCategory/GetAllCategories",
                            Method = "GET",
                            Description = "Get all dine in categories",
                            Param = "None"
                        },
                        GetCategory = new
                        {
                            Url = $"{apiUrl}/api/DineInCategory/GetCategory/{{id}}",
                            Method = "GET",
                            Description = "Get a dine in category by id",
                            Param = "id: int"
                        }
                    }

                };
                return Ok(new ResponseDTO()
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong. Please try again later." + ex);
            }
        }
    }
}