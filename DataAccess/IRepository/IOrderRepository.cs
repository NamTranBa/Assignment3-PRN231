using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll(string id);
        IEnumerable<Order> GetAllNoId();
        Order GetOrders(int id);
        Task AddOrder(Order Order);
        void UpdateOrder(Order Order);
        Task DeleteOrder(int Order);
    }
}
