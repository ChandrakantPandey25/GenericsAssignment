using System;

namespace GenericsMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum program ");
            Console.WriteLine("Enter 1 to find Maximum of three integers ");
            switch(Convert.ToInt32(Console.ReadLine()))
                {
                case 1:
                   int intResult =MaxInteger.MaximumInt(35, 50, 60);
                    Console.WriteLine("Maximum value is = " + intResult);
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;

            }
        }
    }
}
