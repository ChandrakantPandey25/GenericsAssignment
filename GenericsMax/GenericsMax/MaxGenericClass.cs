using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMax
{
    public class MaxGenericClass<T> where T:IComparable
    {
        public T valueOne, valueTwo, valueThree;
        public MaxGenericClass(T valueOne, T valueTwo, T valueThree)
        {
            this.valueOne = valueOne;
            this.valueTwo = valueTwo;
            this.valueThree = valueThree;
        }
        public static T MaxValue(T valueOne, T valueTwo, T valueThree)
        {
            
            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0 ||
            valueOne.CompareTo(valueTwo) >= 0 && valueOne.CompareTo(valueThree) > 0 ||
             valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) >= 0)
            {
                

                Console.WriteLine("Maximum value is = " + valueOne);
            }


            if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0 ||
                    valueTwo.CompareTo(valueOne) >= 0 && valueTwo.CompareTo(valueThree) > 0 ||
                    valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) >= 0)
            {
                Console.WriteLine("Maximum value is = " + valueTwo);
            }

            if (valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) > 0 ||
                    valueThree.CompareTo(valueOne) >= 0 && valueThree.CompareTo(valueTwo) > 0 ||
                    valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) >= 0)
            {
                Console.WriteLine("Maximum value is = " + valueThree);
            }
            return default;

        }
    }
}
