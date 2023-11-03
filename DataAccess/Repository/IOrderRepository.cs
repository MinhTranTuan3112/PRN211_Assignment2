using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public Order AddNewOrder(Order order);
        public List<Order> GetOrdersByMemberID(int MemberId, DateTime? StartDate = null, DateTime? EndDate = null);
        public List<Order> GetAllOrders(bool isSort = false, DateTime? StartDate = null, DateTime? EndDate = null);
        public void UpdateOrder(Order order);
        public void DeleteMemberOrders(int MemberId);

    }
}
