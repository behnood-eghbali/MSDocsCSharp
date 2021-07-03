using System;

namespace AbstractKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new DerivedClass();
            o.AbstractMethod();
            Console.WriteLine($"x = {o.X}, y = {o.Y}");
        }
    }
    // Output: x = 111, y = 161
}
