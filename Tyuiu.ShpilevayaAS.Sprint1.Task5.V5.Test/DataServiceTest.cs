using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint1.Task5.V5.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            double x = 15.984;
            DataService ds = new DataService();
            int res = ds.Calculate(x);

            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
