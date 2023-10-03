using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Application.Dtos;
using OrderProcessing.Application.Interfaces;

namespace OrderProcessing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder orderService;
        public OrderController(IOrder orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrderAsync([FromBody] CreateOrderDto order)
        {
            await orderService.CreateOrderAsync(order);
            return Ok("Sucess");
        }
    }
}
