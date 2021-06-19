using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GenericIEnumerable
{
    public class Program
    {
        // Excercise the Iterator and show that it's more
        // performant.
        public static void Main()
        {
            TestStreamReaderEnumerable();
            Console.WriteLine("---");
            TestReadingFile();
        }

        public static void TestStreamReaderEnumerable()
        {
            // Check the memory before the iterator is used.
            long memoryBefore = GC.GetTotalMemory(true);
            IEnumerable<String> stringsFound;
            // Open a file with the StreamReaderEnumerable and check for a string.
            try
            {
                stringsFound =
                    from line in new StreamReaderEnumerable(@"c:\temp\tempFile.txt")
                    where line.Contains("string to search for")
                    select line;
                Console.WriteLine("Found: " + stringsFound.Count());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"This example requires a file named C:\temp\tempFile.txt.");
                return;
            }

            // Check the memory after the iterator and output it to the console.
            long memoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("Memory Used With Iterator = \t"
                + string.Format(((memoryAfter - memoryBefore) / 1000).ToString(), "n") + "kb");
        }

        public static void TestReadingFile()
        {
            long memoryBefore = GC.GetTotalMemory(true);
            StreamReader sr;
            try
            {
                sr = File.OpenText("c:\\temp\\tempFile.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"This example requires a file named C:\temp\tempFile.txt.");
                return;
            }

            // Add the file contents to a generic list of strings.
            List<string> fileContents = new List<string>();
            while (!sr.EndOfStream)
            {
                fileContents.Add(sr.ReadLine());
            }

            // Check for the string.
            var stringsFound =
                from line in fileContents
                where line.Contains("string to search for")
                select line;

            sr.Close();
            Console.WriteLine("Found: " + stringsFound.Count());

            // Check the memory after when the iterator is not used, and output it to the console.
            long memoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("Memory Used Without Iterator = \t" +
                string.Format(((memoryAfter - memoryBefore) / 1000).ToString(), "n") + "kb");
        }
    }
    // This example displays output similar to the following:
    //       Found: 2
    //       Memory Used With Iterator =     33kb
    //       ---
    //       Found: 2
    //       Memory Used Without Iterator =  206kb
}
