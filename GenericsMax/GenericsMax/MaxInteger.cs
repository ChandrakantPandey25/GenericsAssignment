using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMax
{
    class MaxInteger
    {
        public static int MaximumInt(int valueOne, int valueTwo, int valueThree)
        
        {
            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0)
               return valueOne;
            
            if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0)            
                return valueTwo;

            else              
                return valueThree;
        }
    }
}
