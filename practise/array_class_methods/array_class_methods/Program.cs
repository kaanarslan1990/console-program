using System;

namespace array_class_methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Sort

            int[] numArray = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("******* Unordered List******");
            foreach (var num in numArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("*******Ordered List******");
            Array.Sort(numArray);
            foreach (var num in numArray)
            {
                Console.WriteLine(num);
            }


            // Clear
            Console.WriteLine("*******Array Clear******");

            Array.Clear(numArray,2,2);
            foreach (var num in numArray)
            {
                Console.WriteLine(num);
            }

            // Reverse
            Console.WriteLine("*******Array Reverse******");

            Array.Reverse(numArray);
            foreach (var num in numArray)
            {
                Console.WriteLine(num);
            }

            // IndexOf
            Console.WriteLine("*******IndexOf******");



            Console.WriteLine(Array.IndexOf(numArray, 23));


            // Resize
            Console.WriteLine("*******Resize******");

            Array.Resize<int>(ref numArray, 9);
            numArray[8] = 99;
            foreach (var num in numArray)
            {
                Console.WriteLine(num);

            }





        }
    }
}
