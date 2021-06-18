using System;
using System.Collections;

namespace NonGenericIComparable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList temperatures = new ArrayList();
            // Initialize random number generator.
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int degrees = rnd.Next(0, 100);
                Temperature temp = new Temperature();
                temp.Fahrenheit = degrees;
                temperatures.Add(temp);
            }

            // Sort ArrayList.
            temperatures.Sort();

            foreach (Temperature temp in temperatures)
                Console.WriteLine(temp.Fahrenheit);
        }
    }
    // The example displays the following output to the console (individual
    // values may vary because they are randomly generated):
    //       2
    //       7
    //       16
    //       17
    //       31
    //       37
    //       58
    //       66
    //       72
    //       95
}
