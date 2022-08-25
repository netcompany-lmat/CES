using ces.Models;
using ces.ORM;
using ces.Services;
using ces.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;

namespace ces.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet("GetOrders")]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
         var orders = await _orderService.GetOrders();
            if (orders.Count < 0)
            {
                return NotFound();
            }
            else
            {
                return orders;
            }
        }

        [HttpDelete("DeleteOrder/{Id}")]
        public async Task<HttpStatusCode> DeleteOrder(Guid id)
        {
             _orderService.DeleteOrder(id);
              return  HttpStatusCode.OK;
        }


        [HttpPut("UpdateOrder")]
        public async Task<HttpStatusCode> UpdateOrder(Order order)
        {
            _orderService.UpdateOrder(order);
            return HttpStatusCode.OK;
        }


        [HttpPost("InsertOrder")]
        public async Task<HttpStatusCode> InsertOrder(Order order)
        {
            _orderService.UpdateOrder(order);
            return HttpStatusCode.Created;
        }


        [HttpGet("GetOrderById")]
        public async Task<ActionResult<Order>> GetOrderById(Guid Id)
        {

            var order = await _orderService.GetOrderById(Id);
           
            if (order == null)
            {
                return NotFound();
            }
            else
            {
                return order;
            }
        }


    }
}