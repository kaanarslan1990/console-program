using  System;

namespace type_conversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // implicit conversion
            Console.WriteLine("***** implicit conversion ******");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:"+d);

            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:"+i);

            string e = "khan";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:"+g);

            // explicit conversion

            Console.WriteLine("***** explicit conversion ******");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+v);

            // ***** ToString Method *****
            Console.WriteLine("***** ToString Method ******");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:"+zz);


            // System.convert

            Console.WriteLine("***** System.convert class ******");
            string s1 = "10", s2="20";
            int num1, num2;
            int total;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            total = num1 + num2;

            Console.WriteLine("total:"+total);

            // parse

            Console.WriteLine("***** Parse Method ******");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string text1 = "10";
            string text2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(text1);
            double1 =Double.Parse(text2);

            Console.WriteLine("rakam1:"+ rakam1);
            Console.WriteLine("double1:"+ double1);



        }
    }
}
