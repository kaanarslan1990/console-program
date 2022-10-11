using System;

namespace if_else_ternary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Good morning Sir!");
            }

            else if (time >=13 &&time < 18)
            {
                Console.WriteLine("Good afternoon Sir!");
            }
            else
            {
                Console.WriteLine("Have good night Sir!");
            }

            string sonuc = time <= 18 ? "Good day!" : "Good night";
            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
