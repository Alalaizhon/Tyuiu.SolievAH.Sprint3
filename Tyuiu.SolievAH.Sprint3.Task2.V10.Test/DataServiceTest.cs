using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint3.Task2.V10.Lib;

namespace Tyuiu.SolievAH.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 1, 13);
            Assert.AreEqual(7.5, res);
        }
    }
}
