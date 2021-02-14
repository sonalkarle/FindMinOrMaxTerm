
using System;

namespace FindMinOrMaxTerm
{
    public class findMaxNum
    {
        public float GetMaximumInteger(float first_Number, float second_Number, float third_Number)
        {
            if (first_Number > second_Number && first_Number > third_Number)
                return first_Number;
            else if (second_Number > third_Number)
                return second_Number;
            else
                return third_Number;
        }


        static void Main(string[] args)
        {

        }
    }
}