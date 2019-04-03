using System;
using System.Collections.Generic;
using System.Text;
using EnitityLayer;
using System.Linq;

namespace DataLayer
{
    public class DLLDev
    {
        /// <summary>
        /// Get all products mock
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            List<Product> lstProduct = new List<Product>();
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductId = 1;
            product1.ProductName = "Product1";
            product1.StockAvailable = 10;
            product1.CreatedAt = DateTime.Now;
            product1.UpdatedAt = DateTime.Now;
            lstProduct.Add(product1);
            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductId = 1;
            product2.ProductName = "Product2";
            product2.StockAvailable = 20;
            product2.CreatedAt = DateTime.Now;
            product2.UpdatedAt = DateTime.Now;
            lstProduct.Add(product2);
            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductId = 2;
            product3.ProductName = "Product4";
            product3.StockAvailable = 30;
            product3.CreatedAt = DateTime.Now;
            product3.UpdatedAt = DateTime.Now;
            lstProduct.Add(product3);
            Product product4 = new Product();
            product4.Id = 4;
            product4.ProductId = 3;
            product4.ProductName = "Product4";
            product4.StockAvailable = 40;
            product4.CreatedAt = DateTime.Now;
            product4.UpdatedAt = DateTime.Now;
            lstProduct.Add(product4);
            return lstProduct;
        }

        /// <summary>
        /// Get product by Id and Quantity
        /// </summary>
        /// <returns>List<Product></returns>
        public List<Product> GetProductByIdandQuantity(int productid, int quantity)
        {
            List<Product> lstProduct = GetAllProducts();
            lstProduct = lstProduct.Where(x => x.ProductId == productid).ToList();
            lstProduct = (lstProduct.Count >= quantity) ? lstProduct : null;
            return lstProduct;
        }
    }
}
