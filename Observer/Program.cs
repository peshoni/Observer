using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        private static Available availableList;
        private static Warehouse warehouse;
        private static SupplyList supply;
        private static SalesList sales;

       static void Main( string [] args )
        { 
            warehouse = new Warehouse();
            supply = new SupplyList(warehouse);
            availableList = new Available(warehouse);
            sales = new SalesList(warehouse); 

            Console.WriteLine("Before delivery..");
            showAvailable();    

            warehouse.MakeDelivery(new Delivery("Firm1", "Stoka 1" , 1000));
            warehouse.MakeDelivery(new Delivery("Firm2", "Stoka 1", 2000));
            warehouse.MakeDelivery(new Delivery("Firm1", "Stoka 1", 3000));
            warehouse.MakeDelivery(new Delivery("Firm3", "Stoka 1", 1));
            warehouse.MakeDelivery(new Delivery("Firm1", "Stoka 1", 20));
            warehouse.MakeDelivery(new Delivery("Firm1", "Stoka 1", 300));
            warehouse.MakeDelivery(new Delivery("Firm3", "Stoka 3", 100));
            warehouse.MakeDelivery(new Delivery("Firm1", "Stoka 3", 200));
            warehouse.MakeDelivery(new Delivery("Firm1", "Stoka 3", 300));

           
            Console.WriteLine("After delivery..");
            showDeliveryes();
            showAvailable(); 

            Console.WriteLine("Available : ");
            showAvailable();
            try
            {
                warehouse.MakeASale(new Sale("random client", "Stoka 1", 259));
                warehouse.MakeASale(new Sale("random client2", "Stoka 1", 1000));
                warehouse.MakeASale(new Sale("random client3", "Stoka 1", 10)); 
                warehouse.MakeASale(new Sale("random client4", "Stoka 3", 1000)); 
            }
            catch (Exception)
            { 
                Console.WriteLine("\t\tIt's time to delivery!!!!!!! \n");
            } 
            
            Console.WriteLine("Sold : ");
            showSales();
           
            Console.WriteLine("Available AFTER SOLD: ");
            showAvailable();  
        }

        private static void showSales()
        {
            foreach (DictionaryEntry item in sales.Table)
            {
                Console.WriteLine("ID {0} , Buyer {1}, Product: {2}, quantity: {3}", item.Key,
                    ((Sale)item.Value).Buyer,
                    ((Sale)item.Value).ProductName,
                    ((Sale)item.Value).Quantity);
            }
            Console.WriteLine();
        }

        private static void showDeliveryes()
        {
            int sum = 0;
            foreach (DictionaryEntry item in supply.Table)
            {
                Console.WriteLine("ID {0} | {1} | {2} | {3}", item.Key,
                    ((Delivery)item.Value).ProductName,
                    ((Delivery)item.Value).ProviderName,
                    ((Delivery)item.Value).Quantity);
                sum += ((Delivery)item.Value).Quantity;
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine();
        }

        private static void showAvailable()
        {
            if (availableList.Table.Count <= 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else { 
            foreach (DictionaryEntry item in availableList.Table)
            {
                Console.WriteLine("ID {0} , Product: {1}, quantity: {2}", item.Key,
                    ((Product)item.Value).Name,
                    ((Product)item.Value).Quantity);
            }
            Console.WriteLine();
            }
        }
    }
}
