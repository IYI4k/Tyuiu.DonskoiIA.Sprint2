using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DonskoiIA.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return [a - 1 < b | c == d, a + 5 != b & c > d, a <= b + 100 || c != d, a - 57 < b && c > d,!(a > b) == c + 60 >= d, a > b ^ c == d - 20];
        }
    }
}