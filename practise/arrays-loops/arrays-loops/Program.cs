using System;
using System.Runtime.InteropServices;

namespace arrays_loops
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // array definition

            string[] colors = new string[5];

            string[] animals = { "cat", "dog", "bird" };

            int[] dizi;

            dizi = new int[5];


            // assign value and access

            colors[0] = "Blue";
            Console.WriteLine(animals[0]);
            Console.WriteLine(colors.GetValue(0));

            dizi[3] = 10;
            Console.WriteLine(dizi[3]);

            // loops with arrays

            Console.Write("please enter your array length:  ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] numArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter {0}. number:", i+1);
                numArray[i] = int.Parse(Console.ReadLine());

            }

            int total = 0;


            foreach (var num in numArray)
                total += num;

            Console.WriteLine("Average :" + total/arrayLength);














        }
    }
}
