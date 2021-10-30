using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b : ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("число a={0}, число в = {1}", a, b);
            Console.WriteLine("Введите тип операции:");
            Console.WriteLine("1-сложение");
            Console.WriteLine("2-вычитание");
            Console.WriteLine("3-умножение");
            Console.WriteLine("4-деление");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш выбор:{0}", c);
            Console.ReadKey();
            double res;
            if (c == 1)
            {
                try
                {
                    res = a + b;
                    Console.WriteLine($"Результат: {res}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }

                Console.ReadKey();

            }
            if (c == 2)
            {
                try
                {
                    res = a - b;
                    Console.WriteLine($"Результат: {res}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }

                Console.ReadKey();

            }
            if (c == 3)
            {
                try
                {
                    res = a * b;
                    Console.WriteLine($"Результат: {res}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }

                Console.ReadKey();

            }
            if (c == 4)
            {
                
                try
                {
                    res = a / b;
                    Console.WriteLine($"Результат: {res}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }
                                
                Console.ReadKey();
            }
        }
    }
}
