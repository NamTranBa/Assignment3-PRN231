using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IOrderDetailsRepository
    {
        IEnumerable<OrderDetail> GetAllOrderDetails();
        IEnumerable<OrderDetail> GetOrderDetails(int id);
        OrderDetail GetOrderDetails(int oid, int pid);
        Task AddOrderDetail(OrderDetail OrderDetail);
        void UpdateOrderDetail(OrderDetail OrderDetail);
        Task DeleteOrderDetail(int oid, int pid);
    }
}
