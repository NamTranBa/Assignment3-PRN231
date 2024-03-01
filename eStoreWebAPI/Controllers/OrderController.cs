using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.IRepository;
using BusinessObject.DTO;
using AutoMapper;

namespace eStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _ord;
        private readonly IMapper _map;
        public OrdersController(IOrderRepository ord, IMapper map)
        {
            _ord = ord;
            _map = map;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders(string id)
        {
            var list = _ord.GetAll(id);
            var listmap = _map.Map<IEnumerable<OrderDTO>>(list);
            return Ok(listmap);
        }

        
        // GET: api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var ord = _ord.GetOrders(id);
            var ordmap = _map.Map<OrderDTO>(ord);
            return Ok(ordmap);
        }

        // PUT: api/Orders/5
        // To ordtect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, OrderComposeDTO Order)
        {
            if (id != Order.OrderId)
            {
                return BadRequest();
            }

            var ord = _map.Map<Order>(Order);
            _ord.UpdateOrder(ord);

            return Ok(ord);
        }

        // POST: api/Orders
        // To ordtect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderComposeDTO Order)
        {
            var ord = _map.Map<Order>(Order);
            await _ord.AddOrder(ord);
            return Ok(ord);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _ord.DeleteOrder(id);
            return Ok();
        }
    }
}
