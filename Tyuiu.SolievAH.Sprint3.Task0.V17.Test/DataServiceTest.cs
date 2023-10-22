using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint3.Task0.V17.Lib;

namespace Tyuiu.SolievAH.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSeries(1, 10);

            Assert.AreEqual(-0.42, res);
        }
    }
}
