using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.CherepanovAE.ConsoleApp.Lab1.V1.Lib
{
    public class DataService
    {
        public double SolveExpressV_1_1(double x, double y, double a)
        {
            double result = ((3 + x / y) / ((2 * a) / x)) - ((3 * x * a + 2 * a + a * y) / (3 * a + 2 * x - y)) + (10 * y * a);
            return result;
        }

        public double SolveExpressV_1_2(double x, double y, double a)
        {
            double result = (3 * x) + ((3 * x + y - 4 * a) / (a + 2 * x + 7 * y)) + 5 + (((a / y) + 1) / ((2 * a) / (x)));
            return result;
        }

        public double SolveExpressV_3_1(double x, double y, double a)
        {
            double result = 10 * x - (x / y) / (2 * a / x) + (3 * x + 2 * a - a) / (3 * a + 2 * x + y) - 2 * x;
            return result;
        }

        public double SolveExpressV_3_2(double x, double y, double a)
        {
            double result = 9 * x - (x / y) / (2 * a / x) + (3 * x + 2 * a + a) / (3 * a + 2 * x - y) + 12 * x;
            return result;
        }
    }
}