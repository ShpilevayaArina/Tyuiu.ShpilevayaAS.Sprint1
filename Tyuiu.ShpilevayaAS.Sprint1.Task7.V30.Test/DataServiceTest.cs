using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint1.Task7.V30.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
