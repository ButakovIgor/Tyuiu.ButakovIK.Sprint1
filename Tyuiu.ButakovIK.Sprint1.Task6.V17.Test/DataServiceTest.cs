using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ButakovIK.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool value = ds.CheckPalindrome("топот");
            Assert.AreEqual(true, value);
        }
    }
}
