using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            ProductDAO.Instance.AddProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            ProductDAO.Instance.DeleteProduct(product);
        }

        public List<Product> GetProductList(FilterProductData data)
        {
            return ProductDAO.Instance.GetProductList(data);
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.Instance.UpdateProduct(product);
        }
    }
}
