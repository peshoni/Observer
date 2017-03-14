using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Available : Observer
    {
        private Hashtable table; 

        public Hashtable Table
        {
            get
            {
                return table;
            }
        }

        public Available(Warehouse aWarehouse) { 
            this.table = new Hashtable ();
            this.warehouse = aWarehouse;
            this.warehouse.attachObserver(this);      
        }
 

        public override void update()
        {
            if (warehouse.IsSold) {
                sellProduct(warehouse.Sale);
            }
            if (warehouse.IsDelivery) {
                addProduct(warehouse.Delivery);
            }
        }

        private void sellProduct( Sale sale )
        {
            string key = sale.ProductName; 
          if (Table.ContainsKey(key)){
                if (((Product)Table [key]).Quantity<sale.Quantity)
                {
                    ((Product)Table [key]).Quantity -= sale.Quantity;
                    throw new Exception();
                }  
           } 
        }

        private void addProduct( Delivery delivery )
        {  
            string key = delivery.ProductName;
            if (!Table.ContainsKey(key)){
                 Table.Add(delivery.ProductName, new Product(delivery.ProductName, delivery.Quantity));
            }else {
                 ((Product)Table [key]).Quantity += delivery.Quantity;
            }
        }  
    }
}