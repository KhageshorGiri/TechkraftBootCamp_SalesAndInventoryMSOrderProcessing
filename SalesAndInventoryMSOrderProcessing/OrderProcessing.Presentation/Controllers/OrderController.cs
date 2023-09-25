using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult GetOrder()
        {
            return Ok(orderService.GetOrder());
        }
    }
}
