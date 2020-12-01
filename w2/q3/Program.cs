using System;

namespace q3
{
    public delegate void TrafficDel();
    class TrafficSignal
    {
        public void Yellow()
        {
            Console.WriteLine("Start your engines!");
        }

        public void Green()
        {
            Console.WriteLine("GO GO GO!");
        }

        public void Red()
        {
            Console.WriteLine("Patience is a virtue.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal mySignal = new TrafficSignal();

            TrafficDel myTrafficLight = mySignal.Yellow;
            myTrafficLight();

            myTrafficLight = mySignal.Red;
            myTrafficLight();

            myTrafficLight = mySignal.Green;
            myTrafficLight();

        }
    }
}
