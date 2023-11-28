using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovAE.ConsoleApp.Lab5.V2.Lib;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab5.V2.Lib
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSum()
        {
            DataService ds = new DataService();
            int n = 10;
            double s = ds.GetSum(n);
            double wait = 11.958;
            Assert.AreEqual(wait, s);



        }
    }
}