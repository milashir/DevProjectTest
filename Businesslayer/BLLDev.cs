using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using EnitityLayer;

namespace Businesslayer
{
    public class BLLDev
    {
        DLLDev objDLLDev = new DLLDev();

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            List<Product> lstProduct = new List<Product>();
            return objDLLDev.GetAllProducts();
        }

        /// <summary>
        /// Get product by Id and Quantity
        /// </summary>
        /// <returns>List<Product></returns>
        public List<Product> GetProductByIdandQuantity(int productid, int quantity)
        {
            List<Product> lstProduct = objDLLDev.GetProductByIdandQuantity(productid, quantity);
            return lstProduct;
        }
    }
}
