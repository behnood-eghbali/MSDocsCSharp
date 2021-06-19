using System;
using System.Collections.Generic;

namespace GenericIEqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxEqualityComparer boxEqC = new BoxEqualityComparer();

            var boxes = new Dictionary<Box, string>(boxEqC);

            var redBox = new Box(4, 3, 4);
            AddBox(boxes, redBox, "red");

            var blueBox = new Box(4, 3, 4);
            AddBox(boxes, blueBox, "blue");

            var greenBox = new Box(3, 4, 3);
            AddBox(boxes, greenBox, "green");
            Console.WriteLine();

            Console.WriteLine("The dictionary contains {0} Box objects.",
                                boxes.Count);
        }

        private static void AddBox(Dictionary<Box, String> dict, Box box, String name)
        {
            try
            {
                dict.Add(box, name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Unable to add {0}: {1}", box, e.Message);
            }
        }
    }
}
