using System;

namespace Add_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the numbers:");

            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int.TryParse(s1, out num1);
            int.TryParse(s2, out num2);

            int res = num1 + num2;

            Console.WriteLine("Result of addition of {0} and {1} is {2}", num1, num2, res);

          
        }
    }
}
