using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvanchikovDA.Sprint1.Task1.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double x = 1;
            
            var res = ds.Calculate(a, x);
            Assert.AreEqual(0.79, res);

        }
    }
}
