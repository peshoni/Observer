using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Delivery 
    {
        private string providerName;
        private string productName;
        private int quantity;
        #region Getters and setters
        public string ProviderName
        {
            get
            {
                return providerName;
            }

            set
            {
                providerName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        #endregion
        public Delivery(string Provider, string ProductName, int Quantity )
        {
            this.ProviderName = Provider;
            this.ProductName = ProductName;
            this.Quantity = Quantity;
        } 
    }
}