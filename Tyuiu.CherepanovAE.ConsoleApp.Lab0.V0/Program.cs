using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovAE.ConsoleApp.Lab0.V0.Lib;
namespace Tyuiu.CherepanovAE.ConsoleApp.Lab0.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение переменной K");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной W");
            int w = Convert.ToInt32(Console.ReadLine());

            DataService solve = new DataService();

            var result = solve.Add(k, w);

            Console.WriteLine("Сумма K + W = " + result);

            var result1 = solve.Minus(k, w);

            Console.WriteLine("Разность K - W = " + result1);

            var result2 = solve.Mult(k, w);

            Console.WriteLine("Произведение K * W = " + result2);

            var result3 = solve.Div(k, w);

            Console.WriteLine("Отношение K / W = " + result3);

            if (result > 0)
            {
                Console.WriteLine("Сумма " + result + " положительная");
            }
            else if (result < 0)
            {
                Console.WriteLine("Сумма " + result + " отрицательная");
            }
            else if (result == 0)
            {
                Console.WriteLine("Сумма " + result + " равна нулю");
            }

            //int x = 1;
            //int y = 1; 

            //if (x>0 && y>0 )
            //{
            //    Console.WriteLine("Точка в ПЕРВОЙ четверти " );
            //}

            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Точка во ВТОРОЙ четверти ");
            //}

            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Точка в ТРЕТЬЕЙ четверти ");
            //}

            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Точка в ЧЕТВЁРТОЙ четверти ");
            //}

            //else if (x == 0 && y!=0)
            //{
            //    Console.WriteLine("Точка лежит на оси ОРДИНАТ ");
            //}

            //else if (x != 0 && y == 0)
            //{
            //    Console.WriteLine("Точка лежит на оси АБЦИСС ");
            //}

            //else if (x == 0 && y == 0)
            //{
            //    Console.WriteLine("Точка является началом координат ");
            //}

            //Console.ReadKey();



        }
    }
}
