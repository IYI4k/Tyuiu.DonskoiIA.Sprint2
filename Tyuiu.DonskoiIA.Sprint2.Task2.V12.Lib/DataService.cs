using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DonskoiIA.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x > 2 && x < 14 && y > 2 && y < 13)
            {
                if (x < 6 && y > 7 && y < 11)
                {
                    return false;
                }
                
                if (x > 7 && x < 11 && y > 8)
                {
                    return false;
                }
                
                if (x > 5 && x < 9 && y < 5)
                {
                    return false;
                }

                if (x == 13 && (y < 6 || y > 8))
                {
                    return false;
                }

                if (x < 7 && y == 12)
                {
                    return false;
                }

                return true;
            }
            return false;
        }
    }
}