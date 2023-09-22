using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ButakovIK.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.IncomeAmount(2500,20,30);
            Assert.AreEqual(2541.10, Math.Round(res, 2));
        }
    }
}
