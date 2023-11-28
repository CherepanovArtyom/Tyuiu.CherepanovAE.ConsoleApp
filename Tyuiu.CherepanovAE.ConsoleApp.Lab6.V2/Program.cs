using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovAE.ConsoleApp.Lab6.V2.Lib;
namespace Tyuiu.CherepanovAE.ConsoleApp.Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = -5;

            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------------------+");

            for (int i = 0; i <= len - 1; i++)
            {

                if ((Math.Pow(startValue, 3) - 15 * startValue) == 0)
                {
                    Console.WriteLine("Деление на " + valueArray[i] + " невозможно, т.к. знаменатель не должно быть равен нулю");
                    startValue++;
                }
                else
                {
                    Console.WriteLine("|{0,5:d}     |   {1,5:f1}   |", startValue, valueArray[i]);
                    startValue++;
                }


            }




            Console.ReadKey();
        }
    }
}