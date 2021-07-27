﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskCompletion
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            // Wait on a single task with no timeout specified.
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine("taskA Status: {0}", taskA.Status);
            try
            {
                taskA.Wait();
                Console.WriteLine("taskA Status: {0}", taskA.Status);
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }
        }
    }
    // The example displays output like the following:
    //     taskA Status: WaitingToRun
    //     taskA Status: RanToCompletion
}
