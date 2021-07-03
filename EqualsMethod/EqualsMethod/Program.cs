using EqualsMethod.FirstExample;
using EqualsMethod.SecondExample;
using System;

namespace EqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Example
            Console.WriteLine("First Example:");
            Point2D point2D = new Point2D(5, 5);
            Point3D point3Da = new Point3D(5, 5, 2);
            Point3D point3Db = new Point3D(5, 5, 2);
            Point3D point3Dc = new Point3D(5, 5, -1);

            Console.WriteLine("{0} = {1}: {2}",
                              point2D, point3Da, point2D.Equals(point3Da));
            Console.WriteLine("{0} = {1}: {2}",
                              point2D, point3Db, point2D.Equals(point3Db));
            Console.WriteLine("{0} = {1}: {2}",
                              point3Da, point3Db, point3Da.Equals(point3Db));
            Console.WriteLine("{0} = {1}: {2}",
                              point3Da, point3Dc, point3Da.Equals(point3Dc));

            // The example displays the following output:
            //       Point(5, 5) = Point(5, 5, 2): False
            //       Point(5, 5) = Point(5, 5, 2): False
            //       Point(5, 5, 2) = Point(5, 5, 2): True
            //       Point(5, 5, 2) = Point(5, 5, -1): False

            Console.WriteLine("------------------");

            // Second Example
            Console.WriteLine("Second Example:");
            Rectangle r1 = new Rectangle(0, 0, 100, 200);
            Rectangle r2 = new Rectangle(0, 0, 100, 200);
            Rectangle r3 = new Rectangle(0, 0, 150, 200);

            Console.WriteLine("{0} = {1}: {2}", r1, r2, r1.Equals(r2));
            Console.WriteLine("{0} = {1}: {2}", r1, r3, r1.Equals(r3));
            Console.WriteLine("{0} = {1}: {2}", r2, r3, r2.Equals(r3));

            // The example displays the following output:
            //    Rectangle(0, 0, 100, 200) = Rectangle(0, 0, 100, 200): True
            //    Rectangle(0, 0, 100, 200) = Rectangle(0, 0, 150, 200): False
            //    Rectangle(0, 0, 100, 200) = Rectangle(0, 0, 150, 200): False
        }
    }
}
