using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint2.Task6.V12.Lib;

namespace Tyuiu.MezentsevSE.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int x = 2020;
            int y = 3;
            int z = 17;
            string res = ds.FindDateOfPreviousDay(x, y, z);
            string wait = "2020.3.16";
            Assert.AreEqual(wait, res);
        }
    }
}
