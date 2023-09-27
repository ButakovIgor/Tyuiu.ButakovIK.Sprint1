using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint1.Task5.V4.Lib;

namespace Tyuiu.ButakovIK.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int hs = ds.SecondsToHours(20000);
            Assert.AreEqual(5, hs);
        }
    }
}
