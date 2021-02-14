
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
        ///Uc2 :To find the max number in float numbers
          public int GetMaximumFlaot(int first_Number, int second_Number, int third_Number)
        {
            if (first_Number > second_Number && first_Number > third_Number)
                return first_Number;
            else if (second_Number > third_Number)
                return second_Number;
            else
                return third_Number;
        }
        //UC3: Find max string from below
 public string GetMaximumString(string FirstString, string SecondString, string ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0)
                return FirstString;
            else if (SecondString.CompareTo(ThirdString) > 0)
                return SecondString;
            else
                return ThirdString;
        }

//UC4:Extend the program

    public class findMaxNum
    {
         public class findMaxNum<Extra> where Extra : IComparable
    {
        Extra[] Inputlist;


        public findMaxNum(Extra[] Inputlist)
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

//UC5:Extend program to the max
 public class findMaxNum<Extra> where Extra : IComparable
    {
        Extra[] Inputlist;


        public findMaxNum(Extra[] Inputlist)
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



        static void Main(string[] args)
        {

        }
    }
}
