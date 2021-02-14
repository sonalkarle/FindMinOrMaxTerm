
using System;

namespace FindMinOrMaxTerm
{
    public class findMaxNum
    {
         public class TestMaximum<Extra> where Extra : IComparable
    {
        Extra[] Inputlist;


        public TestMaximum(Extra[] Inputlist)
        {
            this.Inputlist = Inputlist;
        }

        public Extra[] SortArray(Extra[] Inputlist)
        {
            Array.Sort(Inputlist);
            return Inputlist;
        }

        public Extra GetMaximumValue()
        {
            Extra[] SortedInputArray = SortArray(Inputlist);
            return SortedInputArray.Last();
        }

        static void Main(string[] args)
        {

        }
    }
}
