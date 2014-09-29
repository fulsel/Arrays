using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeeBall
{



    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[12,5];

            

            while (true)
            {
                Console.WriteLine("Please enter player number. ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the bases. ");
                int bbase = Convert.ToInt32(Console.ReadLine());
                if (number == 999)
                    break;
                if (bbase >= 5)
                    Console.WriteLine("Error");

                grid[number, bbase] += 1;
            }

            Console.WriteLine("Player Summary: ");
            Console.WriteLine("Player   Bases ");

            for (int number = 0; number <= 11; number++)
            {
              
                for (int bbase = 0; bbase <= 4; bbase++)
                {
                    //                    grid[number, bbase] = 0;
                    Console.Write("{0,5}", grid[number, bbase]);
                } 
                Console.WriteLine();


            }


            




      
        }
    }
}
