﻿using System;

namespace VirtualMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass B = new DerivedClass();
            B.DoWork();  // Calls the new method.

            BaseClass A = (BaseClass)B;
            A.DoWork();  // Also calls the new method.
        }
    }
}
