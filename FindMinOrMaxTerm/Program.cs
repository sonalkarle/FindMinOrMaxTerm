using System;
using System.Linq;

namespace TestMaximumNameSpace
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

        public void PrintMax(Extra[] SortedInputArray)
        {
            Console.WriteLine("Max Value: " + SortedInputArray.Last());
        }

        public Extra GetMaximumValue()
        {
            Extra[] SortedInputArray = SortArray(Inputlist);
            PrintMax(SortedInputArray);
            return SortedInputArray.Last();
        }
    }
}