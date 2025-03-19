using ASMS.API.Abstraction;
using ASMS.Base.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IManageOrdersService _service;
        public ServicesController(IManageOrdersService service)
        {
            _service = service;
        }

        [HttpGet("{carBrand}")]
        public IActionResult GetServicesByCarBrand([FromRoute] string carBrand)
        {
            try
            {
                var result = _service.GetServicesByCarBrand(carBrand);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
