using System;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter your decimals:");

            string s0 = Console.ReadLine();
            string s1 = Console.ReadLine();

            double n0, n1, ans = 0.0;

            Double.TryParse(s0, out n0);
            Double.TryParse(s1, out n1);

            Console.WriteLine("Choose among + or - or / *: ");

            char op = Console.ReadLine()[0];
        

            switch (op)
            {
                case '+':
                    ans = n0 + n1;
                    break;
                case '-':
                    ans = n0 - n1;
                    break;
                case '*':
                    ans = n0 * n1;
                    break;
                case '/':
                    ans = n0 / n1;
                    break;
                default:
                    Console.WriteLine("Invalid operator entered.");
                    break;
            }

            Console.WriteLine("Answer is {0}.",ans);
        }
    }
}
