using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders.Model;
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
        public async Task<IActionResult> Get([FromQuery] Order request)
        {
            var response = await _orderService.GetOrderDetailsForAccountAsync(request);

            if (response != null)
            {
                return Ok(response);
            }

            return Ok("Could not find order");


        }

        [HttpPost]
        [Route("CreateOrder")]
        public async Task<IActionResult> NewOrder([FromBody] Order request)
        {
            var response = await _orderService.CreateOrder(request);
            var message = response != null ? "Your order has been created." : "Something went wrong";

            return Ok(message);
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
