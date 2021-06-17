using System;

namespace OverloadingToString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var auto = new Automobile("Lynx", 2016, 4, "V8");
            Console.WriteLine(auto.ToString());
            Console.WriteLine(auto.ToString("A"));
        }
    }
    // The example displays the following output:
    //       2016 Lynx
    //       2016 Lynx, 4 dr. V8
}
