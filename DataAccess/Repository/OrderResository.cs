﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderResository : IOrderRepository
    {
        public Order AddNewOrder(Order order)
        {
            return OrderDAO.Intsance.AddNewOrder(order);
        }
    }
}
