using System;

namespace Bai3
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.Write("Select an option:   ");
        }
        static void Main(string[] args)
        {
            int option;
            do
            {
                Menu();
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option != 0);

            Console.ReadLine();
        }
    }
}
