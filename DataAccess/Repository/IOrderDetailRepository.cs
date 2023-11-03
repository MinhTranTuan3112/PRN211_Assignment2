using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public void AddNewOrderDetail(OrderDetail orderDetail);
        public OrderDetail GetOrderDetail(int OrderId, int ProductId);
        public void Remove(OrderDetail orderDetail);
        public void AddOrderDetailsList(List<OrderDetail> orderDetailsList);
        public void RemoveByIds(int OrderId, int ProductId);
        public List<OrderDetail> GetOrderDetailsListFromOrder(int OrderId);
    }
}
