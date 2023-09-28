using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint1.Task6.V10.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "привет мир";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "привет мр";
            Assert.AreEqual(wait, res);
        }
    }
}
