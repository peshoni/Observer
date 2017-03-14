using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Sale 
    {
        private string buyer;
        private string productName;
        private int quantity;
        #region Getters and setters
        public string Buyer
        {
            get
            {
                return buyer;
            }

            set
            {
                buyer = value;
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
        /// <summary>
        /// Constructor with two parameters.
        /// </summary>
        /// <param name="Buyer">The Buyer of goods </param>
        /// <param name="aProduct">Product subject to purchas.</param>
        public Sale(string BuyerName, string ProductName, int Quantity ) {
            this.Buyer = BuyerName;
            this.ProductName = ProductName;
            this.Quantity = Quantity; 
        }
       
    }
}