namespace Statistics
{
    using System;
    using System.Linq;

    public class TestPrintStatisctics
    {
        public static void Main()
        {
            double[] numbers = new double[] { 0.13, 1.23, 8.3, 9.23 };
            PrintStatistics(numbers);
        }

        public static void PrintStatistics(double[] numbers)
        {
            Console.WriteLine("The smallest number is {0}", numbers.Min());
            Console.WriteLine("The largest number is {0}", numbers.Max());
            Console.WriteLine("The average of the numbers is {0}", numbers.Average());
        }
    }
}
