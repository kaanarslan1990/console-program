using System;

namespace console_programlama
{
    internal class Program

    {
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Fill your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Fill your surname:");
        string surName = Console.ReadLine();

        Console.WriteLine("Hello " + name + " " + surName);


    }
    }
}
