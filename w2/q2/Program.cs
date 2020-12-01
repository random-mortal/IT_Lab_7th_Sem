using System;

namespace q2
{
    class Item
    {
        public string Name { get; set; }

        private static decimal cost = 0.1m;
        
        public decimal Cost
        {
            get { return cost; }

            set
            {
                if (value <= 0)
                    Console.WriteLine("Cost change unsucccessful. Cost has to be positive.");
                else
                    cost = value;
            }
        }

        public decimal CalcGst()
        {
            return 0.08m * Cost;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Item pizza = new Item();

            Console.WriteLine("Cost = {0}, GST = {1}", pizza.Cost, pizza.CalcGst());

            pizza.Cost = 100;
            Console.WriteLine("Cost = {0}, GST = {1}", pizza.Cost, pizza.CalcGst());

            pizza.Cost = -666;
        }
    }
}
