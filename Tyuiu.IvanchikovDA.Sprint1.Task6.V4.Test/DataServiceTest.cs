using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            string value = "384";
            bool res = ds.CheckNumber(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
