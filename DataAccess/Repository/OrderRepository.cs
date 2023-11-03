using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Order AddNewOrder(Order order)
        {
            return OrderDAO.Instance.AddNewOrder(order);
        }

        public List<Order> GetAllOrders(bool isSort = false,DateTime? StartDate = null, DateTime? EndDate = null)
        {
            return OrderDAO.Instance.GetAllOrders(isSort, StartDate, EndDate);
        }

        public List<Order> GetOrdersByMemberID(int MemberId, DateTime? StartDate = null, DateTime? EndDate = null)
        {
            return OrderDAO.Instance.GetOrdersByMember(MemberId, StartDate, EndDate);
        }

        public void UpdateOrder(Order order)
        {
            OrderDAO.Instance.UpdateOrder(order);
        }

        public void DeleteMemberOrders(int MemberId)
        {
            OrderDAO.Instance.DeleteMemberOrders(MemberId);
        } 
    }
}
