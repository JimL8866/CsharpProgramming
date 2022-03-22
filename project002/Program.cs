using System;

namespace project002
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;
            //Console.WriteLine(x++);    //y = 3
            //int y = 3;
            //y++;
            //Console.WriteLine(y);    // y = 4
            //int z = 3;
            //Console.WriteLine(++z); // z = 4
            //int w = 3;
            //++w;
            //Console.WriteLine(w); //w = 4
            //int v = 3;
            //++v;
            //Console.WriteLine(++v); //v = 5
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num2 == 0)
            //{
            //    int num3 = (int)num1;
            //    Console.WriteLine(num3);
            //}
            //else if (num2 == 1) {
            //    double num4 = ((int)((num1 + 0.05) * 10))/10.0;   // divided by digital then to double, (int)
            //    Console.WriteLine(num4);
            //}
            //Console.WriteLine('8' - 'c');
            //Console.WriteLine('a' - '0');

            //int numDay = Convert.ToInt32(Console.ReadLine());
            //switch (numDay)
            //{
            //    case 1:
            //        Console.WriteLine("Arduino");
            //        break;             
            //    case 2:
            //        Console.WriteLine("Arduino");
            //        break;                
            //    case 3:
            //        Console.WriteLine("C++");
            //        break;                 
            //    case 4:
            //        Console.WriteLine("C++");
            //        break;                 
            //    case 5:
            //        Console.WriteLine("Scratch");
            //        break;                 
            //    case 6:
            //        Console.WriteLine("Scratch");
            //        break;
            //    default:
            //        Console.WriteLine("Have some rest");
            //        break;
            //}
            //int num = 1;
            //while (num < 10)
            //{
            //    Console.WriteLine(num);
            //    num++; 
            //}

            //int i = 0;
            //while (i < 1000)
            //{
            //    i++;
            //    Console.WriteLine(i); 
            //}
            //int x = 0;
            //int m = 1;
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (m<n+1)
            //{
            //    x += m;
            //    m++;
            //}
            //Console.WriteLine(x);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //while (a < b +1)
            //{
            //    if (a % 2 == 0) {
            //        Console.WriteLine(a);
            //    }
            //    a++; 
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;
            //while (n > 1)
            //{
            //    if (n % 2 != 0)
            //    {
            //        n = (n * 3) + 1;

            //    }
            //    else
            //    {
            //        n = n / 2;
            //    }
            //    counter++; 
            //}
            //Console.WriteLine(counter);

            //int n = 0; 
            //while (n < 10 + 1) 
            //{
            //    Console.WriteLine(n);
            //        n++; 
            //}
            //int year = 2006;
            //double students = 80000;
            //int counter = 0;
            //while (students <=200000)
            //{
            //    students *= 1.25;
            //    counter++;
            //}
            //Console.WriteLine(year + counter);
            //int studentsNumber = Convert.ToInt32(Console.ReadLine());
            //int number = 1;
            //int totalAge = 0;
            //while (number <= studentsNumber)
            //{
            //    Console.WriteLine("Please put in the age of students");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    totalAge += age;
            //    number++;
            //}
            //double avgAge = (int)((totalAge * 1.0 / studentsNumber) * 100) / 100.0;
            //Console.WriteLine(avgAge);

            //double x = (int)((50 * 1.0 / 6) * 100) / 100.0;
            //Console.WriteLine(x);
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = 1;
            //while (m <= n)
            //{
            //    Console.Write($"{m} ");
            //    m++;
            //}
            //int sum = 0;
            //for(int i = 1; i <101; i++ )
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int m = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (m < n)
            //{
            //   if (m % 17 ==0)
            //    {
            //        sum += m;
            //    }
            //    m++; 
            //}
            //Console.WriteLine(sum);

            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = m; i < n + 1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            for (int i = m; i < n + 1; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
