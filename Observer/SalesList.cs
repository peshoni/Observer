using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SalesList : Observer
    {
        private Hashtable table;
        private int ID;

        public Hashtable Table
        {
            get
            {
                return table;
            } 
        }

        public SalesList( Warehouse aWarehouse )
        {
            this.table = new Hashtable(); 
            this.warehouse = aWarehouse;
            this.warehouse.attachObserver(this);
        }
 

        public override void update()
        {
            sellProduct(warehouse.Sale);
        }
/// <summary>
/// Registering sold in the table.
/// </summary>
/// <param name="sale"></param>
        private void sellProduct(Sale sale)
        {
            if (sale != null && warehouse.IsSold)
            {
                Table.Add(++ID, sale);
            }
        }
    }
}
