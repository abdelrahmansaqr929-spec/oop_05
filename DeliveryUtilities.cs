using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace oop
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSubSeparator()
        {
            Console.WriteLine("------------------------------------------");
        }

        public static void PrintSystemTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine(title);
            PrintSeparator();
        }
    }
}