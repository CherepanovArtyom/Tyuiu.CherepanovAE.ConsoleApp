using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.CherepanovAE.ConsoleApp.Lab6.V2.Lib;
namespace Tyuiu.CherepanovAE.ConsoleApp.Lab6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;

            valueWaitArray = new double[len];

            valueWaitArray[0] = 153.52;

            valueWaitArray[1] = 108.10;
            valueWaitArray[2] = 32.52;
            valueWaitArray[3] = 10.73;
            valueWaitArray[4] = 1.46;


            valueWaitArray[6] = 0.54;
            valueWaitArray[7] = 5.27;
            valueWaitArray[8] = 21.48;
            valueWaitArray[9] = 19.90;
            valueWaitArray[10] = 96.48;


            double[] res;
            res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}