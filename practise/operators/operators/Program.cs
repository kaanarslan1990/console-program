using System;

namespace operators
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // assign and assign operators
            Console.WriteLine("*********assign and assign operators*************");

            int x = 3;
            int y = 2;

            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            // logic operators
            Console.WriteLine("*******logic operators*****");
            // || && !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            else
            {
                Console.WriteLine("Not good");
            }


            if(isSuccess || isCompleted)
                Console.WriteLine("Great");


            //relational operators
            Console.WriteLine("*******relational operators*****");
            // <,>, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);

            //aritmetic operators
            Console.WriteLine("*******aritmetic operators*****");

            // /,*,+,-

            int num1 = 10;

            int num2 = 5;
            int res1 = num1 * num2;
            Console.WriteLine("10*5:"+ res1);
            res1 = num1 + num2;
            Console.WriteLine("10+5:"+res1);
            res1 = num1 - num2;
            Console.WriteLine("10-5:"+res1);
            res1 = num1 / num2;
            Console.WriteLine("10/5:"+res1);

            res1 = ++num1;
            int res2 = num1++;
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(num1);


            // % : mod alır

            int res3 = 20 % 3;
            Console.WriteLine(res3);








        }
    }
}
