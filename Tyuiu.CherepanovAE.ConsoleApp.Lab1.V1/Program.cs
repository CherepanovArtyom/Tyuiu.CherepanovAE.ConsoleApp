using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovAE.ConsoleApp.Lab1.V1.Lib;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #1 | Выполнил: Черепанов А.Е | НТм-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #1                                                  *");
            Console.WriteLine("* Расчёты арифметических и математических выражений в C#                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Черепанов Артем Евгеньевич | НТм-22-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая выполняет расчёты          *");
            Console.WriteLine("* арифметических и математических выражений.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 4;
            double y = 9;
            double a = -9;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("a = " + a);

            DataService ds = new DataService();

            double result1 = ds.SolveExpressV_3_1(x, y, a);
            double result2 = ds.SolveExpressV_3_2(x, y, a);

            result1 = Math.Round(result1, 13);
            result2 = Math.Round(result2, 12);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" 1-е выражение: " + result1);
            Console.WriteLine(" 2-е выражение: " + result2);
            Console.WriteLine("***************************************************************************");


            Console.ReadKey();
        }
    }
}