using System;

namespace InstanceConstructor
{
    // Instance constructors are used to create and initialize any instance member variables when you use the new expression to create an object of a class.
    // To initialize a static class, or static variables in a non-static class, you define a static constructor.
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Coords();
            var p2 = new Coords(5, 3);

            // Display the results using the overriden ToString method.
            Console.WriteLine($"Coords #1 at {p1}");
            Console.WriteLine($"Coords #2 at {p2}");
            Console.ReadKey();
            Console.WriteLine("-------------------------");
            double radius = 2.5;
            double height = 3.0;

            Circle ring = new Circle(radius);
            Cylinder tube = new Cylinder(radius, height);

            Console.WriteLine("Area of the circle = {0:F2}", ring.Area());
            Console.WriteLine("Area of the cylinder = {0:F2}", tube.Area());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    /* Output:
    Coords #1 at (0,0)
    Coords #2 at (5,3)
    */

    /* Output:
    Area of the circle = 19.63
    Area of the cylinder = 86.39
    */
}
