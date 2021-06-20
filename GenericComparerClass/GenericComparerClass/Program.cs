using System;
using System.Collections.Generic;

namespace GenericComparerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> Boxes = new List<Box>();
            Boxes.Add(new Box(4, 20, 14));
            Boxes.Add(new Box(12, 12, 12));
            Boxes.Add(new Box(8, 20, 10));
            Boxes.Add(new Box(6, 10, 2));
            Boxes.Add(new Box(2, 8, 4));
            Boxes.Add(new Box(2, 6, 8));
            Boxes.Add(new Box(4, 12, 20));
            Boxes.Add(new Box(18, 10, 4));
            Boxes.Add(new Box(24, 4, 18));
            Boxes.Add(new Box(10, 4, 16));
            Boxes.Add(new Box(10, 2, 10));
            Boxes.Add(new Box(6, 18, 2));
            Boxes.Add(new Box(8, 12, 4));
            Boxes.Add(new Box(12, 10, 8));
            Boxes.Add(new Box(14, 6, 6));
            Boxes.Add(new Box(16, 6, 16));
            Boxes.Add(new Box(2, 8, 12));
            Boxes.Add(new Box(4, 24, 8));
            Boxes.Add(new Box(8, 6, 20));
            Boxes.Add(new Box(18, 18, 12));

            // Sort by an Comparer<T> implementation that sorts
            // first by the length.
            Boxes.Sort(new BoxLengthFirst());

            Console.WriteLine("H - L - W");
            Console.WriteLine("==========");
            foreach (Box bx in Boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    bx.Height.ToString(), bx.Length.ToString(),
                    bx.Width.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("H - L - W");
            Console.WriteLine("==========");

            // Get the default comparer that
            // sorts first by the height.
            Comparer<Box> defComp = Comparer<Box>.Default;

            // Calling Boxes.Sort() with no parameter
            // is the same as calling Boxs.Sort(defComp)
            // because they are both using the default comparer.
            Boxes.Sort();

            foreach (Box bx in Boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    bx.Height.ToString(), bx.Length.ToString(),
                    bx.Width.ToString());
            }


            // This explicit interface implementation
            // compares first by the length.
            // Returns -1 because the length of BoxA
            // is less than the length of BoxB.
            BoxLengthFirst LengthFirst = new BoxLengthFirst();

            Comparer<Box> bc = (Comparer<Box>)LengthFirst;

            Box BoxA = new Box(2, 6, 8);
            Box BoxB = new Box(10, 12, 14);
            int x = LengthFirst.Compare(BoxA, BoxB);
            Console.WriteLine();
            Console.WriteLine(x.ToString());
        }
    }
}
