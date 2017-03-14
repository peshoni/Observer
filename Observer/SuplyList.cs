using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SupplyList : Observer
    { 
        private Hashtable table;
        private int ID; 

        public SupplyList( Warehouse aWarehouse )
        { 
            this.table = new Hashtable();
            this.warehouse = aWarehouse;
            this.warehouse.attachObserver(this); 
        }
  

        public Hashtable Table
        {
            get
            {
                return table;
            } 
        } 

        /// <summary>
        /// Adds product into suplylist.
        /// </summary> 
        public override void update()
        {
            addProduct(warehouse.Delivery);
        }

        private void addProduct( Delivery delivery)
        {
            if (delivery!=null) {
                Table.Add(++ID, delivery);
            } 
        }
    }
}
