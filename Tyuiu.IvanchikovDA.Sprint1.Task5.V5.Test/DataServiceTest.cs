﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            int k = 12;
            int n = ds.Calculate(k);
            int res = Convert.ToInt32(n);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
