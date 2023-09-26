using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint1.Task4.V2.Lib;

namespace Tyuiu.PyankovaVV.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServieTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32;
            double y = 16;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
