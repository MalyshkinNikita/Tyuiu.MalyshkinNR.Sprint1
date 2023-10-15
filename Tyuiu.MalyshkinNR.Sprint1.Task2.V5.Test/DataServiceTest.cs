using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalyshkinNR.Sprint1.Task2.V5.Lib;

namespace Tyuiu.MalyshkinNR.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int a = 10;


            int res = ds.CalculateSideSquare(a);
            Assert.AreEqual(res, 600);
        }
    }
}