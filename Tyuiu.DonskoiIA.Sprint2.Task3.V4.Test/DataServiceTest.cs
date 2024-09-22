using System;
using Tyuiu.DonskoiIA.Sprint2.Task3.V4.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-10);
            Assert.AreEqual(-109.9, res);
        }
    }
}