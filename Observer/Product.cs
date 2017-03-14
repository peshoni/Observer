using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Product
    {
        private string name;
        private int quantity;
        public Product(string aName, int aQuantity)
        {
            this.Name = aName;
            this.Quantity = aQuantity;
        }
        #region Getters and setters
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
    }
}
