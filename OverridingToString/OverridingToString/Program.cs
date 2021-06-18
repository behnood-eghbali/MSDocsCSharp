using System;

namespace OverridingToString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ObjectClass objInstance = new ObjectClass('a');
            Console.WriteLine(objInstance.ToString());
        }
    }
    
    // The example displays the following output:
    //       ObjectInstance: a
}
