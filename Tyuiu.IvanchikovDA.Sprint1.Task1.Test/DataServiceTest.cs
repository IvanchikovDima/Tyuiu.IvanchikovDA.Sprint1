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
            const double pi = 3.14;
            double x = 1.0;
            double a = 2.0;
            
            var res = ds.Calculate(x, a);
            Assert.AreEqual(0.79, res);

        }
    }
}
