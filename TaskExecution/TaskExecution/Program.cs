using System;
using System.Threading.Tasks;

namespace TaskExecution
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await Task.Run(() => {
                // Just loop.
                int ctr = 0;
                for (ctr = 0; ctr <= 1000000; ctr++)
                { }
                Console.WriteLine("Finished {0} loop iterations",
                                ctr);
            });
        }
    }
    // The example displays the following output:
    //        Finished 1000001 loop iterations
}
