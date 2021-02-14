
using System;

namespace FindMinOrMaxTerm
{
    public class findMaxNum
    {
        public int GetMaximumInteger(int first_Number, int second_Number, int third_Number)
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