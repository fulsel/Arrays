using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = { 18040, 18042, 18045, 18111, 18112, 18113, 18114, 18115, 18116, 18117 };

            Console.WriteLine("Please Enter a Zip Code: ");
            string input = Console.ReadLine();
            int zipcode = Convert.ToInt32(input);

            bool found = false;
            for (int i = 0; i < zip.Length; i++)
            {
                if (zipcode == zip[i])
                {
                    Console.WriteLine("We deliver to that zipcode!");
                    found = true;
                    break;
                }
                
            }
            if (!found)
                Console.WriteLine("Sorry, We don't deliver to that zipcode.");

        }
    }
}
