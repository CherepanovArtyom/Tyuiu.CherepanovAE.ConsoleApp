using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab5.V2.Lib
{
    public class DataService
    {
        public double GetSum(int n)
        {
            double S = 0;
            for (int x = 1; x <= n; x++)
            {
                S = S + (1 + Math.Cos(x * x) / (x * x));
            }
            return Math.Round(S, 3);


        }
    }
}