using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        //Fields
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }


        //Methods
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance is null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            using var _context = new SalesManagementDbContext();
            _context.Add(orderDetail);
            _context.SaveChanges();
        }

        public OrderDetail GetOrderDetail(int OrderId, int ProductId)
        {
            using var _context = new SalesManagementDbContext();
            return _context.OrderDetails.SingleOrDefault(od => od.OrderId == OrderId && od.ProductId == ProductId);
        }

        public void Remove(OrderDetail orderDetail)
        {
            try
            {
                using var _context = new SalesManagementDbContext();
                _context.Remove(orderDetail);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddOrderDetailsList(List<OrderDetail> orderDetailsList)
        {
            try
            {
                using var _context = new SalesManagementDbContext();
                foreach (var orderDetail in orderDetailsList)
                {
                    // Ensure the associated Order and Product are being tracked by the context
                    var order = _context.Orders.Find(orderDetail.OrderId);
                    var product = _context.Products.Find(orderDetail.ProductId);

                    if (order != null && product != null)
                    {
                        // Attach the Order and Product to the OrderDetail
                        orderDetail.Order = order;
                        orderDetail.Product = product;

                        // Add the OrderDetail to the context
                        _context.OrderDetails.Add(orderDetail);
                    }
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveByIds(int OrderId, int ProductId)
        {
            try
            {
                using var _context = new SalesManagementDbContext();
                _context.OrderDetails.Where(od => od.OrderId == OrderId && od.ProductId == ProductId)
                    .ExecuteDelete();

                _context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<OrderDetail> GetOrderDetailsListFromOrder(int OrderId)
        {
            try
            {
                using var _context = new SalesManagementDbContext();
                return _context.OrderDetails.Include(od => od.Order)
                    .Include(od => od.Product)
                    .Where(od => od.OrderId == OrderId)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
