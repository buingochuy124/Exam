using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "gcdmember";
            string password = "gcd123";
            Console.Write("Enter username:   ");
            string CheckTK = Console.ReadLine();
            Console.Write("Enter username:   ");
            string CheckMK = Console.ReadLine();
            if (CheckTK == userName)
            {
                if (CheckMK == password)
                {
                    Console.WriteLine("Successfully !!!");
                }
                else
                {
                    Console.WriteLine("FAIL !!!");
                }
            }
            Console.ReadLine();
        }
    }
}
