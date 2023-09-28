using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint1.Task7.V18.Lib;

namespace Tyuiu.ButakovIK.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double z = ds.Calculate(1, 1);
            Assert.AreEqual(1.913,z);
        }
    }
}
