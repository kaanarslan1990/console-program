using System;

namespace method_overloading
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // out parameters

            string sayi = "999";
            int outSayi;

            bool sonuc =int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Success!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Not success!");
            }

            Methods instance = new Methods();
            instance.Topla(4,5,out int tplamSonuc);

            Console.WriteLine("toplamSonuc="+ tplamSonuc);

            // method overloading

            int ifade = 999;
            instance.writeToScreen(Convert.ToString(ifade));
            instance.writeToScreen(ifade);
            instance.writeToScreen("Khan ", "Lion");

            // method sign
            // methodname +  parameter length + parameter

        }
    }

    class Methods
    {
        public void Topla(int a, int b, out int toplam)
        {

            toplam = a + b;
        }

        public void writeToScreen(string veri)
        {
            Console.WriteLine(veri);

        }
        public void writeToScreen(int veri)
        {
            Console.WriteLine(veri);

        }
        public void writeToScreen(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);

        }
    }
}
