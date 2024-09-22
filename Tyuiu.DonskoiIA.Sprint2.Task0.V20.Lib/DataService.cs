using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DonskoiIA.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return [x - 800 == y, x - 800 != y, x - 801 < y, x - 800 > y, x - 800 <= y, x - 801 >= y];
        }
    }
}