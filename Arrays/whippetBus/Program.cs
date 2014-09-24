using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your trip distance in miles. ");
            int miles = Convert.ToInt32(Console.ReadLine());

            if (miles <= 99)
                Console.WriteLine("The price of each ticket is $25.00.");
            else if (miles >= 100 && miles <= 299)
                Console.WriteLine("The pirce of each ticket is $40.00.");
            else if (miles >= 300 && miles <= 499)
                Console.WriteLine("The price of each ticket is $55.00");
            else
                Console.WriteLine("The price of each ticket is $70.00");
        }
    }
}
