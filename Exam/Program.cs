using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 1, 4, 5, 7, 9, 9, 2, 5, 2, 3, 4, 2, 1, 1, 6, 7, 7 };

            int Sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                Sum = Sum + Array[i];
            }
            Console.WriteLine("Sum:  " + Sum);

            int Max = 0;
            int Min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Max)
                {
                    Max = Array[i];
                }
                if (Array[i] < Min)
                {
                    Min = Array[i];
                }
            }
            Console.WriteLine("Max:  " + Max);
            Console.WriteLine("Min:  " + Min);

            Console.Write("Array:   ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine();
            int Count = 0;
            for (int i = Min; i <= Max; i++)
            {
                for (int j = 0; j < Array.Length; j++)
                {
                    if (i == Array[j])
                    {
                        Count++;
                    }
                }
                Console.WriteLine($"So {i} lap lai {Count} lan");
                Count = 0;
            }


            int[] Le = new int[Array.Length];
            int[] Chan = new int[Array.Length];
            int m = 0;
            int n = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if ((Array[i] % 2) == 0)
                {
                    Chan[m] = Array[i];
                    m++;
                }
                else
                {
                    Le[n] = Array[i];
                    n++;
                }
            }
            Console.Write("Mang so le:  ");
            for (int i = 0; i < Le.Length; i++)
            {
                if (Le[i] == 0)
                {
                    break;
                }
                Console.Write(Le[i]);
                Console.Write(" ");

            }
            Console.WriteLine();
            Console.Write("Mang so chan:  ");
            for (int i = 0; i < Chan.Length; i++)
            {
                if (Chan[i] == 0)
                {
                    break;
                }
                Console.Write(Chan[i]);
                Console.Write(" ");

            }

            Console.ReadLine();
        }
    }
}
