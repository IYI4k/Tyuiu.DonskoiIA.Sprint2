using System;
using Tyuiu.DonskoiIA.Sprint2.Task4.V18.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1, 0);
            Assert.AreEqual(0, res);
        }
    }
}