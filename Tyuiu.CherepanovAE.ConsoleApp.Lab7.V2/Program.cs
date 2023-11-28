using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovAE.ConsoleApp.Lab7.V2.Lib;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt16(Console.ReadLine());
            int[] numsArray = new int[len];
            Random random = new Random();

            Console.WriteLine("Введите начало диапазона чисел в массиве: ");
            int start = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона чисел в массиве: ");
            int end = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число, наличие которого в массиве вы хотите проверить: ");
            int num = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = random.Next(start, end);
            }

            Console.WriteLine("****************************************");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            DataService ds = new DataService();
            Console.WriteLine();
            Console.WriteLine("Количество отрицательных элементов: " + ds.CountNegativeNumInArray(numsArray));
            Console.WriteLine("Количество положительных элементов: " + ds.CountPositiveNumInArray(numsArray));
            Console.WriteLine("Количество четных элементов: " + ds.CountChetNumInArray(numsArray));
            Console.WriteLine("Количество нечетных элементов: " + ds.CountNeChetNumInArray(numsArray));
            Console.WriteLine("Число " + num + "находится в массиве: " + ds.CountNumInArray(numsArray, num));
            Console.WriteLine("Среднее значение элементов массива равно: " + ds.CountMiddleNumInArray(numsArray));
            Console.WriteLine("Минимальное значение элементов массива равно: " + ds.CountMinNumInArray(numsArray));


            Console.ReadKey();
        }
    }
}