﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int     i = 0;  // Here is my frist line of code.

            i++;
            // I removed a line on a branch.
            Console.Write("I'll never delete a line.");

            Console.WriteLine("Hit Enter to Continue...");
            Console.ReadLine();
        }
    }
}
