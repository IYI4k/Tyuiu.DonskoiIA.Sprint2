using System;
using Tyuiu.DonskoiIA.Sprint2.Task1.V13.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetLogicOperations(145, 916, 164, 137);
            CollectionAssert.AreEqual(new bool[6] { true, true, true, true, true, false }, res);
        }
    }
}