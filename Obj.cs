﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleIO
{
    class Obj
    {
        public static void ObjectFunctionality()
        {
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();

        }
    }
}
