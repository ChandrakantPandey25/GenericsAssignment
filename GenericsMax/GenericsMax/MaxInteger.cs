using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMax
{
    class MaxInteger
    {
        public static int MaximumInt(int valueOne, int valueTwo, int valueThree)

        {
            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0 ||
                   valueOne.CompareTo(valueTwo) >= 0 && valueOne.CompareTo(valueThree) > 0 ||
                   valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) >= 0)

                return valueOne;


            if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0 ||
                    valueTwo.CompareTo(valueOne) >= 0 && valueTwo.CompareTo(valueThree) > 0 ||
                    valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) >= 0)
                return valueTwo;

            if (valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) > 0 ||
                    valueThree.CompareTo(valueOne) >= 0 && valueThree.CompareTo(valueTwo) > 0 ||
                    valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) >= 0)

                return valueThree;

            return valueOne;

        }
    }
}
