using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Delivery 
    {
        private string _providerName;
        private string _productName;
        private int _quantity;
        #region Getters and setters
        public string ProviderName
        {
            get
            {
                return _providerName;
            }

            set
            {
                _providerName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }

            set
            {
                _productName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }
        #endregion
        public Delivery(string Provider, string ProductName, int Quantity )
        {
            this._providerName = Provider;
            this._productName = ProductName;
            this._quantity = Quantity;
        } 
    }
}