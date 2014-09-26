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
            int[] grid = new int[11];

            Console.WriteLine("Please enter player number. ");
            int number0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base0 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter player number. ");
            int number11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the bases. ");
            int base11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player Summary");
            Console.WriteLine("Player Bases");
            Console.WriteLine("Player   Zero   One   Two   Three   Four");
            Console.WriteLine("");

            if (base0 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number0, base0);
            if (base0 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number0, base0);
            if (base0 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number0, base0);
            if (base0 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number0, base0);
            if (base0 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number0, base0);

            if (base1 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number1, base1);
            if (base1 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number1, base1);
            if (base1 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number1, base1);
            if (base1 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number1, base1);
            if (base1 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number1, base1);

            if (base2 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number2, base2);
            if (base2 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number2, base2);
            if (base2 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number2, base2);
            if (base2 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number2, base2);
            if (base2 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number2, base2);

            if (base3 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number3, base3);
            if (base3 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number3, base3);
            if (base3 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number3, base3);
            if (base3 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number3, base3);
            if (base3 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number3, base3);

            if (base4 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number4, base4);
            if (base4 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number4, base4);
            if (base4 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number4, base4);
            if (base4 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number4, base4);
            if (base4 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number4, base4);

            if (base5 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number5, base5);
            if (base5 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number5, base5);
            if (base5 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number5, base5);
            if (base5 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number5, base5);
            if (base5 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number5, base5);


            if (base6 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number6, base6);
            if (base6 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number6, base6);
            if (base6 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number6, base6);
            if (base6 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number6, base6);
            if (base6 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number6, base6);



            if (base7 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number7, base7);
            if (base7 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number7, base7);
            if (base7 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number7, base7);
            if (base7 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number7, base7);
            if (base7 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number7, base7);


            if (base8 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number8, base8);
            if (base8 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number8, base8);
            if (base8 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number8, base8);
            if (base8 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number8, base8);
            if (base8 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number8, base8);


            if (base9 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number9, base9);
            if (base9 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number9, base9);
            if (base9 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number9, base9);
            if (base9 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number9, base9);
            if (base9 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number9, base9);


            if (base10 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number10, base10);
            if (base10 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number10, base10);
            if (base10 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number10, base10);
            if (base10 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number10, base10);
            if (base10 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number10, base10);


            if (base11 == 0)
                Console.WriteLine("{0,3}     {1,3}      0     0      0       0", number11, base11);
            if (base11 == 1)
                Console.WriteLine("{0,3}       0    {1,3}     0     0       0", number11, base11);
            if (base11 == 2)
                Console.WriteLine("{0,3}       0      0   {1,3}      0      0", number11, base11);
            if (base11 == 3)
                Console.WriteLine("{0,3}       0      0     0    {1,3}       0", number11, base11);
            if (base11 == 4)
                Console.WriteLine("{0,3}       0      0     0      0     {1,3}", number11, base11);


            




      
        }
    }
}
