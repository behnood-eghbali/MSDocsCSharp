using System;

namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Person object by using the instance constructor.
            Person person1 = new Person("George", 40);

            // Create another Person object, copying person1.
            Person person2 = new Person(person1);

            // Change each person's age.
            person1.Age = 39;
            person2.Age = 41;

            // Change person2's name.
            person2.Name = "Charles";

            // Show details to verify that the name and age fields are distinct.
            Console.WriteLine(person1.Details());
            Console.WriteLine(person2.Details());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    // Output:
    // George is 39
    // Charles is 41
}
