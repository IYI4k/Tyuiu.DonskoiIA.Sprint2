using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DonskoiIA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            k = (k + d - 2) % 7;

            string ans = "";

            switch (k)
            {
                case 0:
                    ans = "Понедельник";
                    break;
                case 1:
                    ans = "Вторник";
                    break;
                case 2:
                    ans = "Среда";
                    break;
                case 3:
                    ans = "Четверг";
                    break;
                case 4:
                    ans = "Пятница";
                    break;
                case 5:
                    ans = "Суббота";
                    break;
                case 6:
                    ans = "Воскресенье";
                    break;
            }
            return ans;
        }
    }
}