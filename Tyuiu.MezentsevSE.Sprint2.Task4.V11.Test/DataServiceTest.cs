using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MezentsevSE.Sprint2.Task4.V11.Lib;

namespace Tyuiu.MezentsevSE.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 121;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = - 156;
            double res = ds.Calculate(x, y);
            double wait = -155.987;
            Assert.AreEqual(wait, res);
        }
    }
}
