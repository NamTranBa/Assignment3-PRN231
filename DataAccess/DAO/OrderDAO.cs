using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        private readonly eStore2Context _context;
        public OrderDAO(eStore2Context context)
        {
            _context = context;
        }

        public  IEnumerable<Order> GetAllOrders(string id)
        {
            var listpro =  _context.Orders.Include(m => m.User).Where(i => i.MemberId.Equals(id)).ToList();
            return listpro;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var listpro = _context.Orders.Include(m => m.User).ToList();
            return listpro;
        }

        public  Order GetOrderById(int id)
        {
            var Order =  _context.Orders.Include(c => c.User).SingleOrDefault(i => i.OrderId == id);
            return Order;
        }

        public async Task AddNewOrder(Order Order)
        {
            await _context.Orders.AddAsync(Order);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateOrder(Order Order)
        {
            _context.Entry(Order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var p = await _context.Orders.SingleOrDefaultAsync(i => i.OrderId == id);
            _context.Orders.Remove(p);
            await _context.SaveChangesAsync();
        }
    }
}
