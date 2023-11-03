using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        //Fields
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        //Constructor
        private OrderDAO()
        {

        }

        //Methods
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance is null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public Order AddNewOrder(Order order)
        {
            using var _context = new SalesManagementDbContext();
            _context.Add(order);
            _context.SaveChanges();
            return order;
        }

        public List<Order> GetOrdersByMember(int MemberId, DateTime? StartDate = null, DateTime? EndDate = null)
        {

            using var _context = new SalesManagementDbContext();
            var query = _context.Orders
                .Where(order => order.MemberId == MemberId)
                .Include(order => order.Member)
                .AsQueryable();
            if (StartDate is not null)
            {
                query = query.Where(order => order.OrderDate >= StartDate);
            }

            if (EndDate is not null)
            {
                query = query.Where(order => order.OrderDate <= EndDate);
            }
            query = query.OrderBy(order => order.OrderDate);
            return query.ToList();
        }

        public List<Order> GetAllOrders(bool isSort = false, DateTime? StartDate = null, DateTime? EndDate = null)
        {
            using var _context = new SalesManagementDbContext();
            var query = _context
                .Orders.Include(order => order.Member).AsQueryable();
            if (StartDate is not null)
            {
                query = query.Where(order => order.OrderDate >= StartDate);
            }
            if (EndDate is not null)
            {
                query = query.Where(order => order.OrderDate <= EndDate);
            }
            query = isSort switch
            {
                true => query.OrderBy(order => order.Freight),
                false => query.OrderBy(order => order.OrderDate)
            };
            return query.ToList();
        }

        public void UpdateOrder(Order order)
        {
            using var _context = new SalesManagementDbContext();
            _context.Update(order);
            _context.SaveChanges();
        }

        public void DeleteMemberOrders(int MemberId)
        {
            using var _context = new SalesManagementDbContext();
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var orderList = OrderDAO.Instance.GetOrdersByMember(MemberId);
                foreach (var order in orderList)
                {
                    _context.OrderDetails.Where(od => od.OrderId == order.OrderId).ExecuteDelete();
                }
                _context.Orders.Where(order => order.MemberId == MemberId)
                    .ExecuteDelete();
                _context.SaveChanges();
                transaction.Commit();
            } catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }
    }
}
