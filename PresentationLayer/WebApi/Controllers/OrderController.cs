using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetOrders")]
        public async Task<IEnumerable<OrderViewModel>> GetOrders()
        {
            return await _orderService.GetOrders();
        }

        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder(OrderModel orderModel)
        {
            await _orderService.CreateOrder(orderModel);
            return Ok();
        }
    }
}
