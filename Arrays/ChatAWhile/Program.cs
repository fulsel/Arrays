using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] area = { 262, 414, 608, 715, 815, 920 };
            double[] charge = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            Console.WriteLine("Please Enter an Area Code. ");
            string areacode = Console.ReadLine();
            int areaint = Convert.ToInt32(areacode);
            Console.WriteLine("Please Enter your call time in minutes. ");
            string minutes = Console.ReadLine();
            int minutesint = Convert.ToInt32(minutes);

            double cost = 0;
            int state = 0;
            for(int i = 0; i < area.Length; i++)
            {
                if (areaint == area[i])
                {
                    cost = minutesint * charge[i];
                    Console.WriteLine("Your cost is {0}. ", cost.ToString("C"));
                    state = 1;
                    break;
                }
            }

            if( state ==0)
            Console.WriteLine("Sorry you did not enter a valid area code. ");


            

        }
    }
}
