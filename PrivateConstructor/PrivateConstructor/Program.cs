using System;

namespace PrivateConstructor
{
    // A private constructor is a special instance constructor.
    // It is generally used in classes that contain static members only.
    // If a class has one or more private constructors and no public constructors, other classes (except nested classes) cannot create instances of this class.
    class Program
    {
        static void Main(string[] args)
        {
            // If you uncomment the following statement, it will generate
            // an error because the constructor is inaccessible:
            // Counter aCounter = new Counter();   // Error

            Counter.currentCount = 100;
            Counter.IncrementCount();
            Console.WriteLine("New count: {0}", Counter.currentCount);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    // Output: New count: 101
}
