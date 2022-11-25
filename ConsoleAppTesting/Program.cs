using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите размерность массива:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            string[,] myArray = new string[x, y];
            Console.Clear();
            Console.WriteLine($"Размерность массива: {x},{y}");
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    myArray[i, j] = Convert.ToChar(rnd.Next('a', 'Z' + 30)).ToString();
                    Console.Write(myArray[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
