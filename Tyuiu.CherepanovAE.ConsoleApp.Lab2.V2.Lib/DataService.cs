using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab2.V2.Lib
{
    public class DataService
    {
        public double SolveExpressV_3_1(double x, double y)
        {
            double result = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) + Math.Sin(y)) * Math.Tan(x * y);
            return result;
        }

        public double SolveExpressV_3_2(double x, double y)
        {
            double result = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);
            return result;
        }
    }
}