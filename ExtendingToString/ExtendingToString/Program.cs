using System;

namespace ExtendingToString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list2 = new CList<int>();
            list2.Add(1000);
            list2.Add(2000);
            Console.WriteLine(list2.ToString());
        }
    }
    // The example displays the following output:
    //    1000, 2000
}
