using System;

namespace project005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //char a = 's';
            //Console.WriteLine("\a");
            //            Console.WriteLine(@"c:\xxx\""

            //xx\xxx.doc");

            //string a = Console.ReadLine();
            //Console.WriteLine(a);
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a);

            //Console.WriteLine("Please put in an integer a");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please put in another integer b");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = (a + b) / 2;
            //Console.WriteLine($"The average a + b is {c} ");
            //int money = Convert.ToInt32(Console.ReadLine());
            //int people = Convert.ToInt32(Console.ReadLine());
            //double moneyForEach = money / people;
            //Console.WriteLine(moneyForEach);
            //int a = 33;
            //int b = 43;
            //int c = a + b;
            //Console.WriteLine("the sum of {0} + {1} is {2}", a, b, c);  //格式化字符串
            //Console.WriteLine(45 / 10.0); //4.5
            //Console.WriteLine(45 / 10); //4
            //int a = 45 / 10;
            //Console.WriteLine(a); //4
            //double b = 45 / 10;
            //Console.WriteLine(b);   //4
            //double c = 45 / 10.0;
            //Console.WriteLine(c);  //4.5
            //double e = (double)45 / 10;
            //Console.WriteLine(e);  //4.5

            //int a = Convert.ToInt32(Console.ReadLine());
            //int tens = a / 10;
            //int ones = a % 10;
            //Console.WriteLine(tens);
            //Console.WriteLine(ones);
            //int a = 5;
            //int b = ++a;
            //Console.WriteLine(b); //++放在前面，先增加在赋值。不管怎样a最后都会增加
            //int a = Convert.ToInt32(Console.ReadLine());
            //int thousands = a / 100;
            //int remainder = a % 100;
            //int tens = remainder / 10;
            //int ones = remainder % 10;
            //Console.WriteLine("result is {0}{1}{2}", ones, tens, thousands);
            //int a = 10;
            //int b = 20;
            //int c = 30;
            //Console.WriteLine("" + a + b + c);
            //int a = Convert.ToInt32(Console.ReadLine());
            //int tens = (a / 10) % 10;
            //int thousands = (a / 1000) % 10;
            //int res = thousands * 10 + tens;
            //char res1 = (char)res;
            //Console.WriteLine(res1);
            int a = 3;
            int b = a++ + ++a;  //a 先赋值3，然后自增到4然后自增到5，最后加起来赋值给b
            Console.WriteLine(a); //5
            Console.WriteLine(b); //8




        }
    }
}
