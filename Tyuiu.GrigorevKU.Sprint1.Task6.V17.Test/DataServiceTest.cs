using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint1.Task6.V17.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedPalindromeValid()
        {
            DataService ds = new DataService();
            bool wait = true;
            string strtest = "А РОЗА УПАЛА НА ЛАПУ АЗОРА";
            bool res = ds.CheckPalindrome(strtest);
            Assert.AreEqual(wait, res);
        }
    }
}
