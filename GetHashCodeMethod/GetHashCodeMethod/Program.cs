using GetHashCodeMethod.FirstExample;
using GetHashCodeMethod.SecondExample;
using System;

namespace GetHashCodeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Example
            Console.WriteLine("First Example:");
            Point2D pt2d = new Point2D(5, 8);
            Console.WriteLine(pt2d.GetHashCode());

            pt2d = new Point2D(8, 5);
            Console.WriteLine(pt2d.GetHashCode());

            // The example displays the following output:
            //       13
            //       13

            Console.WriteLine("--------------------");

            // Second Example
            Console.WriteLine("Second Example:");
            Point pt = new Point(5, 8);
            Console.WriteLine(pt.GetHashCode());

            pt = new Point(8, 5);
            Console.WriteLine(pt.GetHashCode());

            // The example displays the following output:
            //       173
            //       269
        }
    }
}
