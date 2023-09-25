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
            double res = ds.IncomeAmount(5000,10,40);
            Assert.AreEqual(54.795, Math.Round(res, 3));
        }
    }
}
