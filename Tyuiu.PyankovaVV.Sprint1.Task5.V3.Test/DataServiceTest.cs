using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.PyankovaVV.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            int k = 18458;
            int wait = 4;
            var res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
