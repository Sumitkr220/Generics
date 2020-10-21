using System;

namespace Generic
{
    class Program
    {
        public static string MaximumIntegerNumber(string firstValue, string secondValue,string thirdValue)
        {
            if(firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue)>0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
              secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
              secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
             thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
             thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
        static void Main(string[] args)
        {
            string output1 = MaximumIntegerNumber("abc", "xbc", "vbc");
            string output2 = MaximumIntegerNumber("kbc", "fbc", "ebc");
            string output3 = MaximumIntegerNumber("mbc", "dbc", "abc");
            Console.WriteLine("Maximum value is: " +output1);
            Console.WriteLine("Maximum value is: " + output2);
            Console.WriteLine("Maximum value is: " + output3);
        }
    }
}
