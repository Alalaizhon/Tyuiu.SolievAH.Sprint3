using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint3.Task1.V30.Lib;
namespace Tyuiu.SolievAH.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(0.5, 1, 12);
            Assert.AreEqual(0.959, res);
        }
    }
}

