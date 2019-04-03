using System;
using System.Collections.Generic;
using System.Text;

namespace EnitityLayer
{
    public class Product
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _productid;
        public int ProductId
        {
            get { return _productid; }
            set { _productid = value; }
        }

        private string _productname;
        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }

        private int _stockavailable;
        public int StockAvailable
        {
            get { return _stockavailable; }
            set { _stockavailable = value; }
        }

        private DateTime _createdat;
        public DateTime CreatedAt
        {
            get { return _createdat; }
            set { _createdat = value; }
        }

        private DateTime _updatedat;
        public DateTime UpdatedAt
        {
            get { return _updatedat; }
            set { _updatedat = value; }
        }
    }
}
