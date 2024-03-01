using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using AutoMapper;
using BusinessObject.DTO;
using DataAccess.IRepository;

namespace eStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsRepository _repository;
        private readonly IMapper _mapper;
        public OrderDetailsController(IOrderDetailsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/OrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetailDTO>>> GetOrderDetails()
        {
            IEnumerable<OrderDetail> list = _repository.GetAllOrderDetails();
            var orderDetailsDto = _mapper.Map<List<OrderDetailDTO>>(list);
            return Ok(orderDetailsDto);
        }

        // GET: api/OrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OrderDetailDTO>>> GetOrderDetail(int id)
        {
            var OrderDetail = _repository.GetOrderDetails(id);
            var orderDetailsDto = _mapper.Map<List<OrderDetailDTO>>(OrderDetail);

            if (OrderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetailsDto);
        }

        [HttpGet("get-id")]
        public async Task<ActionResult<IEnumerable<OrderDetailDTO>>> GetOrderDetailById(int oid, int pid)
        {
            var OrderDetail = _repository.GetOrderDetails(oid, pid);
            var orderDetailsDto = _mapper.Map<OrderDetailDTO>(OrderDetail);

            if (OrderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetailsDto);
        }

        // PUT: api/OrderDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderDetail(OrderDetailDTO OrderDetail)
        {
            var orderDetailsDto = _mapper.Map<OrderDetail>(OrderDetail);
            _repository.UpdateOrderDetail(orderDetailsDto);
            return NoContent();
        }

        // POST: api/OrderDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderDetail>> PostOrderDetail(OrderDetailDTO OrderDetail)
        {
            var orderDetailsDto = _mapper.Map<OrderDetail>(OrderDetail);
            await _repository.AddOrderDetail(orderDetailsDto);
            return Ok();
        }

        // DELETE: api/OrderDetails/5
        [HttpDelete]
        public async Task<IActionResult> DeleteOrderDetail(int oid, int pid)
        {
            await _repository.DeleteOrderDetail(oid, pid);
            return NoContent();
        }
    }
}
