using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool swGoto = false;
            double x, y, sum, enterSw;
            do
            {
                Console.WriteLine("Выберите операцию:\n1 - Сложение, 2 - Вычитание, 3 - Умножение, 4 - Деление");
                enterSw = Convert.ToInt32(Console.ReadLine());
                switch (enterSw)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали сложение");
                        Console.WriteLine("Введите первое число:");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        y = Convert.ToDouble(Console.ReadLine());
                        sum = x - y;
                        Console.Clear();
                        Console.WriteLine($"Результат операции:\n{x} + {y} = {sum}\nНажмите любую клавишу, что бы вернуться на главный экран.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали вычитание");
                        Console.WriteLine("Введите первое число:");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        sum = x + y;
                        Console.WriteLine($"Результат операции:\n{x} - {y} = {sum}\nНажмите любую клавишу, что бы вернуться на главный экран.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали умножение");
                        Console.WriteLine("Введите первое число:");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        sum = x * y;
                        Console.WriteLine($"Результат операции:\n{x} * {y} = {sum}\nНажмите любую клавишу, что бы вернуться на главный экран.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали деление");
                        Console.WriteLine("Введите первое число:");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        sum = x / y;
                        Console.WriteLine($"Результат операции:\n{x} / {y} = {sum}\nНажмите любую клавишу, что бы вернуться на главный экран.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует!");
                        break;
                }
            }
            while (swGoto == false);

        }
    }
}
