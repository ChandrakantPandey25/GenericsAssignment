using System;

namespace GenericsMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum program ");
            Console.WriteLine("Enter 1 to find Maximum of three integers ");
            Console.WriteLine("Enter 2 to find Maximum of three float numbers ");
            Console.WriteLine("Enter 3 to find Maximum of three strings ");
            switch(Convert.ToInt32(Console.ReadLine()))
                {
                case 1:
                   int intResult =MaxInteger.MaximumInt(35, 70, 60);
                    Console.WriteLine("Maximum value is = " + intResult);
                    break;
                case 2:
                    double floatResult = MaxFloat.MaximumFloat(5.5,7.8,25.6);
                    Console.WriteLine("Maximum value is = " + floatResult);
                    break;
                case 3:
                    string stringResult = MaxString.MaximumString("i","am","hero");
                    Console.WriteLine("Maximum value is = " + stringResult);
                    break;


                default:
                    Console.WriteLine("Enter Valid Number");
                    break;

            }
        }
    }
}
