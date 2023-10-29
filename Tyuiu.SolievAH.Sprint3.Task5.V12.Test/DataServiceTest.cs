using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint3.Task5.V12.Lib;

namespace Tyuiu.SolievAH.Sprint3.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(55.748, ds.GetSumSumSeries(5, 1, 1, 3, 10));
        }
    }
}
