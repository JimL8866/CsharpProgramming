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

            int numDay = Convert.ToInt32(Console.ReadLine());
            switch (numDay)
            {
                case 1:
                    Console.WriteLine("Arduino");
                    break;             
                case 2:
                    Console.WriteLine("Arduino");
                    break;                
                case 3:
                    Console.WriteLine("C++");
                    break;                 
                case 4:
                    Console.WriteLine("C++");
                    break;                 
                case 5:
                    Console.WriteLine("Scratch");
                    break;                 
                case 6:
                    Console.WriteLine("Scratch");
                    break;
                default:
                    Console.WriteLine("Have some rest");
                    break;
            }
        }
    }
}
