using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Warehouse
    {    
        private List<Observer> observers = new List<Observer>(); 
        private Delivery delivery;  
        private Sale sale;
        private bool isDelivery;
        private bool isSold;

        #region Getters and Setters 
        public Delivery Delivery
        {
            get
            {
                return delivery;
            }

            set
            {
                delivery = value;
            }
        }

        public List<Observer> Observers
        {
            get
            {
                return observers;
            } 
        }

        public Sale Sale
        {
            get
            {
                return sale;
            }

            set
            {
                sale = value;
            }
        }

        public bool IsDelivery
        {
            get
            {
                return isDelivery;
            }

            set
            {
                isDelivery = value;
            }
        }

        public bool IsSold
        {
            get
            {
                return isSold;
            }

            set
            {
                isSold = value;
            }
        }

        public SalesList SalesList
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal SupplyList SupplyList
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Available Available
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }


        #endregion

        /// <summary>
        /// Called by observers to add to the list with observers.
        /// </summary>
        /// <param name="observer">To be added.</param>
        public void attachObserver( Observer observer ) {
                  Observers.Add(observer);
        }


        public void MakeDelivery( Delivery aDelivеry ) {
                 this.Delivery = aDelivеry;
                 isDelivery = true;                      
                 notifyAll(); 
        }

        public void MakeASale( Sale aSale) { 
                this.Sale = aSale;
                isSold = true;
                notifyAll(); 
        }
       

        /// <summary>
        /// Notify all observers to call 'update()' method. Retuns tha basic state of bool's.
        /// </summary>
        private void notifyAll() {
            Observers.ForEach(element=> {
                element.update();
            });
            isDelivery = false;
            isSold = false;
        }
    }
}
