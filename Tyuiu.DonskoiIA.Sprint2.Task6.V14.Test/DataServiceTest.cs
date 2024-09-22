using System;
using Tyuiu.DonskoiIA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.FindDayName(1, 7);
            Assert.AreEqual("Воскресенье", res);
        }
    }
}