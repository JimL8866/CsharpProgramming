using System;

namespace project001
{
    class Program
    {
        static void Main(String[]args)
        {
            //int a = 4;
            //int b = 3;
            //a = a * a;
            //a = a * b;
            //Console.WriteLine($"{a}and{b}");
            //Console.WriteLine(@"c:\\a\\b""\\c");
            //string str=Console.ReadLine();
            //Console.WriteLine(str+"-");
            //int strInt = Convert.ToInt32(Console.ReadLine());
            //int x = 32;
            //int result = strInt + x;
            //Console.WriteLine($"{strInt}+32 is {result}");
            //int a, b;
            //a = 5;
            //b = 6;
            //Console.WriteLine(a + b);
            //double a = Convert.ToInt32(Console.ReadLine());
            //double b = Convert.ToInt32(Console.ReadLine());
            //double c = (a + b) / 2;
            //Console.WriteLine("average is " + c);
            //int money = 20;
            //int people = 6;
            //Console.WriteLine("Each people can get " + (money / people) + " dollars.");
            //int a = 300, b = 200;
            //Console.WriteLine($"a is {a}");
            //Console.WriteLine($"b is {b}");
            //int c;
            //c = b;
            //b = a;
            //a = c;
            //Console.WriteLine($"a is {a}");
            //Console.WriteLine($"b is {b}");

            //Console.WriteLine("Please put a double digit number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num_1 = num / 10;
            //int num_2 = num % 10;
            //Console.WriteLine($"Double digit number {num} is divided to {num_1} and {num_2}.");

            //Console.WriteLine("Please put a three digit number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num_1 = num / 100;
            //int temp = num % 100;
            //int num_2 = temp / 10;
            //int num_3 = temp % 10; 
            //Console.WriteLine($"Three digit number {num} is divided to {num_1} and {num_2} and {num_3}.");
            //bool a = true, b = false;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (18 <= age && age <= 60)
            //    Console.WriteLine("Access Grented");
            //else
            //    Console.WriteLine("Access Denied");
            //Console.WriteLine("Please put in a five digital number?");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num1 = num / 10000;
            //int num2 = (num%10000) / 1000;
            //int num3 = (num % 10000 % 1000) / 100;
            //int num4 = (num % 10000 % 1000 %100) / 10;
            //int num5 = num2 * 10 + num4;
            //char character = (char)num5;
            //Console.WriteLine($"character is {character}");

            int gradeMath = Convert.ToInt32(Console.ReadLine());
            int gradeEnglish = Convert.ToInt32(Console.ReadLine());
            if (gradeMath >= 90 && gradeEnglish >= 90)
                Console.WriteLine("Reward with Price");

        }

    }
}