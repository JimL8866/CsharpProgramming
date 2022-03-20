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

            //int gradeMath = Convert.ToInt32(Console.ReadLine());
            //int gradeEnglish = Convert.ToInt32(Console.ReadLine());
            //if (gradeMath >= 90 && gradeEnglish >= 90)
            //    Console.WriteLine("Reward with Price");

            //Console.WriteLine("Please put in a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("It is an even number");
            //else
            //    Console.WriteLine("It is an old number");

            //Console.WriteLine("What is your score?");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90 && score <= 100)
            //    Console.WriteLine("A");
            //else if (score >= 70 && score <= 89)
            //    Console.WriteLine("B");
            //else if (score >= 60 && score <= 69)
            //    Console.WriteLine("C");            
            //else 
            //    Console.WriteLine("D");
            //int x = 1;
            //Console.WriteLine(x++);
            //Console.WriteLine(++x);
            //int a = Convert.ToInt32(Console.ReadLine());            
            //int b = Convert.ToInt32(Console.ReadLine());            
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max = a;
            //if (b > max)
            //    max = b;
            //else if (c>max)
            //    max = c;
            //Console.WriteLine(max * max);
            //Console.WriteLine("Please put in a Capital Letter");
            //char letter1 = Convert.ToChar(Console.ReadLine()); 
            //Console.WriteLine("Please put in a Capital Letter");
            //char letter2 = Convert.ToChar(Console.ReadLine());
            //if (letter1 < letter2)
            //    Console.WriteLine(letter2);
            //else
            //    Console.WriteLine(letter1);

            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x-- < 5) Console.WriteLine(x);
            //else Console.WriteLine(x++);
            //int x = 5, a = 0, b = 0;
            //if (x == a + b) 
            //    Console.WriteLine("****");
            //else 
            //    Console.WriteLine("####");

            int x = 21, y = 1;
            if (x % 3 == 0 && x % 7 == 0)
            {
                x--;
                Console.WriteLine(x--);
            }
            else
            {
                x++;
                Console.WriteLine(x++);
            }
        }
    }
}