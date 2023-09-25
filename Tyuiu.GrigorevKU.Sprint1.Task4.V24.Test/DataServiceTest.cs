using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint1.Task4.V24.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            double wait = Math.Round(0 / (1 + Math.Sqrt(2)), 3);
            Assert.AreEqual(res, wait);
        }
    }
}
