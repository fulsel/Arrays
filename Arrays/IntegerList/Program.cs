using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] things = {1,2,3,4,5};
            //int [] things = new int [5];

            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine("Thing #{0} has value {1}", i, things[i] );
            }

        }
    }
}
