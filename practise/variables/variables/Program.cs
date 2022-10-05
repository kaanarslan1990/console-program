using System;

namespace variables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //1 byte 0/256
            sbyte c = 5; //1 byte -128/127

            short s = 5; // 2 byte yer kaplar -32768/32768
            ushort us = 5; //2 byte 0/65365

            Int16 i16 = 2; //2 byte yer kaplar
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte yer kaplar
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 4; //8 byte -+
            ulong ul = 4; //8 byte +

            //reel sayılar
            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; //  16 byte


            char ch = '2'; // 2b byte
            string str = "khan"; // sınırsız

            bool bt = true;
            bool bf = false;

            DateTime dt = DateTime.Now;


            object o1 = "x";
            object o2 = "2";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler
            string str1 = String.Empty;
            str1 = "Khan arslan";
            string ad = "khan";
            string soyad = "arslan";
            string fullName = ad + " " + soyad;
            Console.WriteLine(fullName + (dt));

            // integer tanımlama şekilleri
            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;
            Console.WriteLine(int3);

            //boolean

            bool b1 = 10 < 2;
            Console.WriteLine(b1);

            // degisken dönüsümleri
            string str5 = "20";
            int int5 = 20;


            string newValue = str5 + int5.ToString();
            Console.WriteLine(newValue);

            int int6 = int5 + Convert.ToInt32(str5);
            Console.WriteLine("int6:" + int6); //40

            int int7 = int5 + int.Parse(str5);
            Console.WriteLine("int7:" + int7); //40

            int int8 = int5 + int.Parse(str5);
            Console.WriteLine("int8:" + int8); //40


            //datetime

            string datetime1 = DateTime.Now.ToString("dd.MM.yyy");
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}
