using ASMS.API.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IManageOrdersService _service;
        public OrdersController(IManageOrdersService service)
        {
            _service = service;
        }
        
        [HttpPost("create_new_order")]
        public IActionResult CreateNewOrder([FromQuery] string clientName, string clientPhone, string vin, int serviceId)
        {
            try
            {
                var result = _service.CreateNewOrder(clientName, clientPhone, vin, serviceId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
