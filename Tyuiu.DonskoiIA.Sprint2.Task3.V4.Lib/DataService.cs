using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DonskoiIA.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 1) res = x + Math.Pow(((x + 1) / (x - 1)), x);
            else if (x == 0) res = (x * x + Math.Cos(x * x)) / (x * x - Math.Sin(x * x) + 12);
            else if (x < -8) res = x + 10 * x - 1 / x;
            else res = Math.Pow(x - 1 / (x * x), x);
            return Convert.ToInt64(res * 1000) / 1000.0;
        }
    }
}