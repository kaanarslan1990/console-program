using System;


namespace for_loop
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // // Print odd number to console lower than input number
            // Console.WriteLine("Please enter a number:");
            //
            // int counter = int.Parse(Console.ReadLine());
            //
            // for (int i = 0; i <= counter; i++)
            // {
            //     if(i%2 ==1 )
            //         Console.WriteLine(i);

                // komutlar
            // }

            // odd and even number total between 1 and 1000
            // int oddTotal = 0;
            // int evenTotal = 0;
            // for (int i = 0; i <= 1000; i++)
            // {
            //     if (i % 2 == 1)
            //         oddTotal += i;
            //     else
            //         evenTotal += i;
            //
            // }
            //
            // Console.WriteLine("Odd total= " + oddTotal);
            // Console.WriteLine("Even total= " + evenTotal);

            for (int i = 1; i < 10; i++)
            {

                if (i == 4)
                    break;
                Console.WriteLine(i);

            }

            for (int i = 1; i < 10; i++)
            {

                if (i == 4)
                    continue;
                Console.WriteLine(i);

            }
        }
    }
}
