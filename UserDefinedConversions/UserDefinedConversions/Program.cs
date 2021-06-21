using System;

namespace UserDefinedConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Digit(7);

            byte number = d;
            Console.WriteLine(number);  // output: 7

            Digit digit = (Digit)number;
            Console.WriteLine(digit);  // output: 7
        }
    }
}
