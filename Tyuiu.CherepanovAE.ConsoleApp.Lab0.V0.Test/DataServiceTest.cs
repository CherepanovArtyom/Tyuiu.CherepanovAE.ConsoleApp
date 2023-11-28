using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovAE.ConsoleApp.Lab0.V0.Lib;
namespace Tyuiu.CherepanovAE.ConsoleApp.Lab0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidAdd()
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 15;

            var res = ds.Add(a, b);

            Assert.AreEqual(30, res);
        }
        [TestMethod]
        public void ValidMinus()
        {
            DataService ds = new DataService();

            int a = 25;
            int b = 15;

            var res = ds.Minus(a, b);

            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void ValidMult()
        {
            DataService ds = new DataService();

            int a = 5;
            int b = 6;

            var res = ds.Mult(a, b);

            Assert.AreEqual(30, res);
        }
        [TestMethod]
        public void ValidDiv()
        {
            DataService ds = new DataService();

            int a = 30;
            int b = 5;

            var res = ds.Div(a, b);

            Assert.AreEqual(6, res);
        }
    }
}
