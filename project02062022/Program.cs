using System;

namespace project02062022
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();
            #endregion
            Console.WriteLine("What is your username?");
            string permission = Console.ReadLine();
            int level = 55;
            int level2 = 20;
            Console.WriteLine("What is your user level?");
            int userLevel = Convert.ToInt32(Console.ReadLine());
            if (permission.Contains("Admin")){
                Console.WriteLine(userLevel > level ? "Welcome, Super Admin User" : "Welcome, Admin User");
            }else if (permission.Contains("Manager"))
            {
                Console.WriteLine(userLevel >= level2 ? "Contact an Admin for access" : "You do not have sufficient privileges");
            }else
            {
                Console.WriteLine("You do not have sufficient privileges");
            }




        }
    }
}
