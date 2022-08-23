using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMax
{
    class MaxFloat
    {
        public static double MaximumFloat(double valueOne, double valueTwo, double valueThree)

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
