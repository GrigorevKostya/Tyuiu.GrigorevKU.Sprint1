using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint1.Task5.V3.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            int test = 130985;
            string res = Convert.ToString(ds.Calculate(test));
            string wait = "9";
            Assert.AreEqual(wait, res);

        }
    }
}
