using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailsDAO
    {
        private readonly eStore2Context _context;
        public OrderDetailsDAO(eStore2Context context)
        {
            _context = context;
        }

        public  IEnumerable<OrderDetail> GetAllOrderDetailss()
        {
            var listpro =  _context.OrderDetails.ToList();
            return listpro;
        }
        public  IEnumerable<OrderDetail> GetAllOrderDetailss(int id)
        {
            var listpro =  _context.OrderDetails.Where(o => o.OrderId == id).ToList();
            return listpro;
        }
        public  OrderDetail GetOrderDetailsById(int oid, int pid)
        {
            var OrderDetails =  _context.OrderDetails.FirstOrDefault(i => i.OrderId == oid &&  i.ProductId == pid);
            return OrderDetails;
        }

        public async Task AddNewOrderDetails(OrderDetail OrderDetails)
        {
            await _context.OrderDetails.AddAsync(OrderDetails);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateOrderDetails(OrderDetail OrderDetails)
        {
            _context.Entry(OrderDetails).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int oid, int pid)
        {
            var orderDetail = await _context.OrderDetails
    .FirstOrDefaultAsync(od => od.OrderId == oid && od.ProductId == pid);
            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();
        }
    }
}
