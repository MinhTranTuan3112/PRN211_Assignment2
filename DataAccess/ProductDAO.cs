using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        //Fields
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }


        //Methods
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance is null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Product> GetProductList(FilterProductData data)
        {
            using var _context = new SalesManagementDbContext();
            var query = _context.Products.AsQueryable();
            if (data.ProductId != -1)
            {
                query = query.Where(product => product.ProductId == data.ProductId);
            }
            if (!string.IsNullOrEmpty(data.Keyword))
            {
                query = query.Where(product => product.ProductName.ToLower().Contains(data.Keyword.ToLower()));
            }
            if (data.MinPrice != Decimal.MinusOne)
            {
                query = query.Where(product => product.UnitPrice >= data.MinPrice);
            }
            if (data.MaxPrice != Decimal.MinusOne)
            {
                query = query.Where(product => product.UnitPrice <= data.MaxPrice);
            }
            if (data.MinUnit != -1)
            {
                query = query.Where(product => product.UnitsInStock >= data.MinUnit);
            }
            if (data.MaxUnit != -1)
            {
                query = query.Where(product => product.UnitsInStock <= data.MaxUnit);
            }
            query = query.OrderBy(product => product.ProductName);
            return query.ToList();
        }

        public void AddProduct(Product product)
        {
            using var _context = new SalesManagementDbContext();
            _context.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            using var _context = new SalesManagementDbContext();
            _context.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            using var _context = new SalesManagementDbContext();
            _context.Remove(product);
            _context.SaveChanges();
        }
    }
}
