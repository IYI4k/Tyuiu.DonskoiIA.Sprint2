
using System;

using Tyuiu.DonskoiIA.Sprint2.Task0.V20.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetCompareOperations(1075, 275);
            CollectionAssert.AreEqual(new bool[6] { true, false, true, false, true, false }, res);
        }
    }
}