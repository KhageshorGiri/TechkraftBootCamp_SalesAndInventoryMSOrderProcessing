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

        [HttpGet]
        public async Task<List<GetOrderDto>> GetAllOrders()
        {
            return await orderService.GetAllOrderAsync();
        }

        [HttpGet("{Id}")]
        public async Task<GetOrderDto> GetAllOrdersById(int Id)
        {
            return await orderService.GetOrderByIdAsync(Id);
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrderAsync([FromBody] CreateOrderDto order)
        {
            await orderService.CreateOrderAsync(order);
            return Ok("Sucess");
        }

        [HttpPost("{Id}")]
        public async Task<ActionResult> EditOrderAsync(int Id, [FromBody] EditOrderDto order)
        {
            await orderService.EditOrderAsync();
            return Ok("Sucess");
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> DeletedOrderAsync(int Id)
        {
            await orderService.DeleteOrderAsync(Id);
            return Ok("Sucess");
        }
    }
}
