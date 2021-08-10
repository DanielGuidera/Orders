using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders.Service.Order;

namespace Orders.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("GetOrder")]
        public async Task<IActionResult> Get([FromQuery] GetRequest request)
        {
            var response = await _orderService.GetOrderForAccountAsync(request.AccountId, request.OrderId);
            return Ok(response);
        }
    }

    public class GetRequest
    {
        [Required]
        public int AccountId { get; set; }
        [Required]
        public int OrderId { get; set; }
    }
}
