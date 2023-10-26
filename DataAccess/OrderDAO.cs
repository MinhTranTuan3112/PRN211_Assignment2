using BusinessObject.Models;
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
        public static OrderDAO Intsance
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
    }
}
