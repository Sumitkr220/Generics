using System;

namespace Generic
{
    class Program
    {
        class GenericMaximum<T> where T : IComparable
        {

            public T[] value;
            public GenericMaximum(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[sorted_values.Length - 1];
            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);
            }
        }
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333"};
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
