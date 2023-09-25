using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint1.Task2.V25.Lib;

namespace Tyuiu.ButakovIK.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int radians = 6;
            double res = ds.ConvertRadsToDegrees(radians);
            Assert.AreEqual(343.775, Math.Round(res,3));
        }
    }
}
