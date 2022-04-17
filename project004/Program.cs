using System;

namespace project004
{
    class Program
    {
        static void Main(string[] args)
        {
            // count 9 times
            // int y = 0;
            //for (int i =1; i <=9; i++)
            // {
            //     y++; 
            //     for (int x = 1; x <=i; x++)
            //     {
            //         // 1 * 2    2 * 2
            //         int res = x * y;
            //         Console.Write($"{x} * {y} = {res}  ");
            //     }
            //     Console.WriteLine();
            //}
            //int m = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            ////min?
            //int min = m;
            //if (n<min)
            //{
            //    min = n;
            //}
            //for (int i = min; i >0; i--)
            //{
            //    if (m % i ==0 && n % i ==0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            //random 1-100

            //Random rd = new Random();
            //int ranNum = rd.Next(0, 101);
            //Console.WriteLine(ranNum);
            //while (true)
            //{
            //    Console.WriteLine("Guess a number?");
            //    int userNum = Convert.ToInt32(Console.ReadLine());
            //    if (userNum < ranNum)
            //    {
            //        Console.WriteLine("Guess Number is lower");
            //    }
            //    else if (userNum > ranNum)
            //    {
            //        Console.WriteLine("Guess Numer is higher");            
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are right");
            //        break;
            //    }
            //}
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"my name is {name}");



        }
    }
}
