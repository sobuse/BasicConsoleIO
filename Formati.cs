using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleIO
{
    class Formati
    {
        public static void FormatNumberData()
        {
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 999999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);

            string userMessage = string.Format("100000 in hex is {0:x}", 100000);

            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
