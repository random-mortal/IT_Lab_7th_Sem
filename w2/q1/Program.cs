using System;

namespace q1
{
    public delegate void PriceChangedEventHandler(double newPrice);
    class Item
    {
        private string itemName;
        private double itemPrice;

        public Item(string name, double price)
        {
            itemName = name;
            itemPrice = price;
        }

        public event PriceChangedEventHandler PriceHasChanged;

        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                // price changes here
                // so, fire event
                itemPrice = value;

                if(PriceHasChanged != null)
                {
                    PriceHasChanged(itemPrice);
                }
            }
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Item myItem = new Item("PS5", 40111.1);

            // now connect the event of myItem to the eventhandler
            myItem.PriceHasChanged += myEventHandler;

            //now try changing the price through the property
            myItem.ItemPrice = 007;
            myItem.ItemPrice = 008;
            myItem.ItemPrice = 009;
        }

        public static void myEventHandler(double newPrice)
        {
            Console.WriteLine("The new price is {0}.", newPrice);
        }
    }
}
