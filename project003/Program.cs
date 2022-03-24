using System;

namespace project003
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //bool program = true;
            //while (program) {
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num; 
            //    if (num == 0) {
            //        Console.WriteLine(sum);
            //        break;
            //    }
            //}
            //int sum = 0;
            //int num;
            //do
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //} while (num != 0);
            //Console.WriteLine(sum);

            //int r = convert.toint32(console.readline());
            //int m = convert.toint32(console.readline());
            //int y = convert.toint32(console.readline());
            //for (int i = 0; i <y; i++)
            //{
            //    m = (int)(m * (r / 100.0)) + m; 
            //}
            //console.writeline(m);

            //for (int i =100; i<=999; i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai =i / 100;
            //    if (i ==ge * ge * ge + shi *shi*shi + bai*bai*bai)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //string num = Console.ReadLine();
            ////for (int i =num.Length-1; i >=0; i--)
            ////{
            ////    Console.WriteLine(num[i]);
            ////}
            //foreach (char c in num)
            //{
            //    Console.WriteLine(c);
            //}
            //int num = Convert.ToInt32(Console.ReadLine());
            //while (num !=0)
            //{
            //    int n = num % 10;
            //    Console.WriteLine(n);
            //    num /= 10;
            //}
            //string num = Console.ReadLine();
            //string newNum = "";
            //for (int i=num.Length-1;i>=0; i-- )
            //{
            //    newNum += num[i];
            //}
            //if (num == newNum)
            //{
            //    Console.WriteLine($"Yes. {newNum}");
            //}
            //else
            //{
            //    Console.WriteLine($"No. {newNum}");
            //}
            //char c;
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        sum = sum + c - '0';
            //    }

            //} while (c != '@');
            //Console.Write(sum);
            //int num = Convert.ToInt32(Console.ReadLine());
            //string sum = "";
            //for (int i=1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        sum = sum + i + " ";
            //    }
            //}
            //Console.WriteLine(sum);

            //int num = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;
            //for(int i = 1; i <=num; i++)
            //{
            //    if (num % i ==0)
            //    {
            //        counter++;
            //    }
            //}
            //if (counter == 2)
            //{
            //    Console.WriteLine($"Yes. Prime number is {num}");
            //}

            //for (int num = 1; num <= 100; num++)
            //{
            //    if (num % 2 ==0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(num);
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++ )
            //{
            //    for (int j =0; j<m; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <num +1 ; i++)
            //{
            //    for (int j =0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            //string m ="";
            //for (int i = 1; i < n + 1; i ++)
            //{
            //    for(int j = 0; j <n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //        m += " ";
            //    Console.Write(m);
            //}
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            { 
                for (int j = n - i -1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++) {
                    Console.Write("*");
                }
                for (int h = 0; h < i; h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //n-1 row
            for (int i = 1; i <=n; i++)
            {
                for (int j=0; j <i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (n - i) * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
