using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalyshkinNR.Sprint1.Task7.V8.Lib;

namespace Tyuiu.MalyshkinNR.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 0;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
