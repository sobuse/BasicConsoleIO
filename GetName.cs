using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleIO
{
    class GetName
    {
        public static void GetUserData()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age:  ");
            string userAge = Console.ReadLine();
            Console.WriteLine("Please enter your sex:  ");
            string userSex = Console.ReadLine();

            // Change echo color

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;

            // Echo to the console

            Console.WriteLine( "Hello {0}! you are {1} years old and u r a {2}" , userName, userAge, userSex);

            Console.ForegroundColor = prevColor;
           
        }
    }
}
