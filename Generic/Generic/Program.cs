using System;

namespace Generic
{
    class Program
    {
        public static float MaximumIntegerNumber(float firstValue, float secondValue,float thirdValue)
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
            float output1 = MaximumIntegerNumber(30.9f, 60.89f, 38.98f);
            float output2 = MaximumIntegerNumber(309.8f, 600.98f, 900.8f);
            float output3 = MaximumIntegerNumber(300.98f, 6000.80f, 909.809f);
            Console.WriteLine("Maximum number is: " +output1);
            Console.WriteLine("Maximum number is: " + output2);
            Console.WriteLine("Maximum number is: " + output3);
        }
    }
}
