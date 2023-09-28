using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint1.Task7.V3.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double wait = 4;
            double res = ds.Calculate(0, 1);
            Assert.AreEqual(wait, res);
        }
    }
}
