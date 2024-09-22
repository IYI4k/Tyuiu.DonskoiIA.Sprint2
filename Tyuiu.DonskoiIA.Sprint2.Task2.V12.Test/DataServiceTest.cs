using System;
using Tyuiu.DonskoiIA.Sprint2.Task2.V12.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(6, 8);
            Assert.AreEqual(true, res);
        }
    }
}