using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.AddNewOrderDetail(orderDetail);
        }

        public void AddOrderDetailsList(List<OrderDetail> orderDetailsList)
        {
            OrderDetailDAO.Instance.AddOrderDetailsList(orderDetailsList);
        }

        public OrderDetail GetOrderDetail(int OrderId, int ProductId)
        {
            return OrderDetailDAO.Instance.GetOrderDetail(OrderId, ProductId);
        }

        public void Remove(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.Remove(orderDetail);
        }

        public void RemoveByIds(int OrderId, int ProductId)
        {
            OrderDetailDAO.Instance.RemoveByIds(OrderId, ProductId);
        }
        public List<OrderDetail> GetOrderDetailsListFromOrder(int OrderId)
        {
            return OrderDetailDAO.Instance.GetOrderDetailsListFromOrder(OrderId);
        }
    }
}
