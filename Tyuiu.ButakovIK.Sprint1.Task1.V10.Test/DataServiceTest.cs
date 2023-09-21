using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint1.Task1.V10.Lib;

namespace Tyuiu.ButakovIK.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2, res);
        }
    }
}
