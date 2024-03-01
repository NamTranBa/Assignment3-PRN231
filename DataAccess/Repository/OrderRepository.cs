using BusinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO _orderDAO;
        public OrderRepository(OrderDAO orderDAO)
        {
            _orderDAO = orderDAO;
        }
        public Task AddOrder(Order Order) => _orderDAO.AddNewOrder(Order);
        public async Task DeleteOrder(int id) => await _orderDAO.Delete(id);
        public IEnumerable<Order> GetAll(string id) => _orderDAO.GetAllOrders(id);
        public IEnumerable<Order> GetAllNoId() => _orderDAO.GetAllOrders();
        public Order GetOrders(int id) => _orderDAO.GetOrderById(id);
        public void UpdateOrder(Order Order) => _orderDAO.UpdateOrder(Order);
    }
}
