using System;

namespace _3x___1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = 1; //testing
                           

            for (int i = 0; i <= 1000; i++)
            {
                round(number, 0);
                number++;
            }






        }




        static void round(ulong final, int i)
        {


            Console.Write("For the number: " + final);
            while (final > 1) // loop until the value reaches 1
            {

                final = test(final);
                //Console.WriteLine(final);
                i++;
                Console.Write(".");

            }

            //Console.WriteLine(start);
            Console.WriteLine();
            Console.WriteLine("it took " + i + " iterations to reach 1");
            //Console.WriteLine(i);
            //Console.WriteLine("for loops: " a);






        }



        static ulong test(ulong x)
        {

            if (x % 2 == 0)
            {
                return x / 2;
            }

            else
            {
                return x * 3 + 1;
            }




        }



    }
}
