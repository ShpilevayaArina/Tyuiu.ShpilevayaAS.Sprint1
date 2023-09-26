using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint1.Task4.V27.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = -9;
            double wait = -1.000;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
