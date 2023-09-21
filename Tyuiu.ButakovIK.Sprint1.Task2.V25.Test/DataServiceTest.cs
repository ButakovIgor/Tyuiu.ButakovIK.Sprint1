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
            int rads = 2;
            double res = ds.ConvertRadsToDegrees(rads);
            Assert.AreEqual(114.592, Math.Round(res,3));
        }
    }
}
