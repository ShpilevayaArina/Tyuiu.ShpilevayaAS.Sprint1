using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint1.Task2.V25.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 314;
            double res = ds.ConvertRadsToDegrees(value);
            Assert.AreEqual(18000, res);
        }
    }
}
