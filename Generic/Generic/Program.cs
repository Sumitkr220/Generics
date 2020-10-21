using System;

namespace Generic
{
    class Program
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue,int thirdValue)
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
            int output1 = MaximumIntegerNumber(30, 60, 38);
            int output2 = MaximumIntegerNumber(3098, 600, 900);
            int output3 = MaximumIntegerNumber(30098, 600000, 909800);
            Console.WriteLine("Maximum number is: " +output1);
            Console.WriteLine("Maximum number is: " + output2);
            Console.WriteLine("Maximum number is: " + output3);
        }
    }
}
