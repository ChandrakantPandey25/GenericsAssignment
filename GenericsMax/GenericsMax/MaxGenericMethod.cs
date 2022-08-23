using System;

namespace GenericsMax
{
    class MaxGenericMethod
    {
        public  static void  GenericMethod<T>(T valueOne, T valueTwo, T valueThree)where T :IComparable

        {
            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0 ||
                   valueOne.CompareTo(valueTwo) >= 0 && valueOne.CompareTo(valueThree) > 0 ||
                   valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) >= 0)
            

                Console.WriteLine("Maximum value is = " + valueOne);
            


            if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0 ||
                    valueTwo.CompareTo(valueOne) >= 0 && valueTwo.CompareTo(valueThree) > 0 ||
                    valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) >= 0)
                Console.WriteLine("Maximum value is = " + valueTwo);

            if (valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) > 0 ||
                    valueThree.CompareTo(valueOne) >= 0 && valueThree.CompareTo(valueTwo) > 0 ||
                    valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) >= 0)

                Console.WriteLine("Maximum value is = " + valueThree);

            
        }
    }
}
