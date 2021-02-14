
using System;

namespace FindMinOrMaxTerm
{
    public class findMaxNum
    {
        public string GetMaximumString(string FirstString, string SecondString, string ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0)
                return FirstString;
            else if (SecondString.CompareTo(ThirdString) > 0)
                return SecondString;
            else
                return ThirdString;
        }

        static void Main(string[] args)
        {

        }
    }
}