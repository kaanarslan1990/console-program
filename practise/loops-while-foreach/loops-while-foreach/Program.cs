using System;

namespace loops_while_foreach
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // while
            Console.WriteLine("Please, enter a number: ");

            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            int total = 0;

            while (counter <= num)
            {

                total += counter;
                counter++;

            }

            Console.WriteLine(total/num);

            // letters wrote to console a to z

            char character = 'a';

            while (character <= 'z')
            {
                Console.Write(character + "-");
                character++;
            }

            Console.Write("********Foreach **********");

            string[] cars = { "BMV", "FORD", "TOYOTA", "NISSAN" };


            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
