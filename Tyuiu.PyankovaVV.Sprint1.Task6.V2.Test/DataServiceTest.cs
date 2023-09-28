﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.PyankovaVV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "Hello world!";
            bool res = ds.CheckHello(text);
            Assert.AreEqual(true, res);
        }
    }
}
