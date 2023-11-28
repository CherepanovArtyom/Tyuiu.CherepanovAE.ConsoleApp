using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.CherepanovAE.ConsoleApp.Lab4.V2.Lib
{
    public class DataService
    {
        public bool GetPointShape(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y <= x / 2))

            {
                res = true;

            }

            else
            {
                res = false;
            }

            return res;
        }
    }
}