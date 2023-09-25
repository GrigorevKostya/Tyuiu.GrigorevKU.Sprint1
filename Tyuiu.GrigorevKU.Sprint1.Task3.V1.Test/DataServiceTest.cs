using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint1.Task3.V1.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 4;
            double wait = Math.Round(Math.PI * 16, 3);
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(res, wait);
        }
    }
}
