using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyankovaVV.Sprint1.Task2.V12.Lib;

namespace Tyuiu.PyankovaVV.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10; int y = 5; int z = 4;
            int res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(200, res);
        }
    }
}
