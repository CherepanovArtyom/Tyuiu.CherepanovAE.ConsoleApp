using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovAE.ConsoleApp.Lab2.V2.Lib;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionV_3_1()
        {
            double x = 5;
            double y = 6;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_3_1(x, y);

            result = Math.Round(result, 15);
            double wait = 0.642908201949371;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidExpressionV_3_2()
        {
            double x = 5;
            double y = 6; ;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_3_2(x, y);

            result = Math.Round(result, 14);
            double wait = 1.18469833596795;

            Assert.AreEqual(wait, result);
        }
    }
}