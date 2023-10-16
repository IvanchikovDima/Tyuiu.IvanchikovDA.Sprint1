using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2.0;
            int amountNotebook = 3;
            double pricePencil = 6.0;
            int amountPencil = 8;
            double wait = 54;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);
        }
    }
}
