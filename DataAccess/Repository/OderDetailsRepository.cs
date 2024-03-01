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
    public class OrderDetailRepository : IOrderDetailsRepository
    {
        private readonly OrderDetailsDAO _orderDetailsDAO;
        public OrderDetailRepository(OrderDetailsDAO orderDetailsDAO)
        {
            _orderDetailsDAO = orderDetailsDAO;
        }
        public Task AddOrderDetail(OrderDetail OrderDetail) => _orderDetailsDAO.AddNewOrderDetails(OrderDetail);
        public Task DeleteOrderDetail(int oid, int pid) => _orderDetailsDAO.Delete(oid, pid);
        public IEnumerable<OrderDetail> GetAllOrderDetails() => _orderDetailsDAO.GetAllOrderDetailss();
        public IEnumerable<OrderDetail> GetOrderDetails(int id) => _orderDetailsDAO.GetAllOrderDetailss(id);
        public OrderDetail GetOrderDetails(int oid, int pid) => _orderDetailsDAO.GetOrderDetailsById(oid, pid);
        public void UpdateOrderDetail(OrderDetail OrderDetail) => _orderDetailsDAO.UpdateOrderDetails(OrderDetail);
    }
}
