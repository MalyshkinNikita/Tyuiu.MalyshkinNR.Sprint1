using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalyshkinNR.Sprint1.Task4.V3.Lib;
namespace Tyuiu.MalyshkinNR.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double res = 0.75;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}