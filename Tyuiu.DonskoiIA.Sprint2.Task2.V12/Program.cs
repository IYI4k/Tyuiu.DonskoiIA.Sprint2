using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint2.Task2.V12.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя значения для x и y *");
            Console.WriteLine("* , после чего определяет находится ли данная точка в заштрихованной      *");
            Console.WriteLine("* области и выводит отвевт на экран                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                           11  13  15                    *");
            Console.WriteLine("*                       1 2 3 4 5 6 7 8 9 10| 12| 14|                     *");
            Console.WriteLine("*                     1 ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░                     *");
            Console.WriteLine("*                     2 ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░                     *");
            Console.WriteLine("*                     3 ░ ░ X X X ░ ░ ░ X X X X ░ ░ ░                     *");
            Console.WriteLine("*                     4 ░ ░ X X X ░ ░ ░ X X X X ░ ░ ░                     *");
            Console.WriteLine("*                     5 ░ ░ X X X X X X X X X X ░ ░ ░                     *");
            Console.WriteLine("*                     6 ░ ░ X X X X X X X X X X X ░ ░                     *");
            Console.WriteLine("*                     7 ░ ░ X X X X X X X X X X X ░ ░                     *");
            Console.WriteLine("*                     8 ░ ░ ░ ░ ░ X X X X X X X X ░ ░                     *");
            Console.WriteLine("*                     9 ░ ░ ░ ░ ░ X X ░ ░ ░ X X ░ ░ ░                     *");
            Console.WriteLine("*                    10 ░ ░ ░ ░ ░ X X ░ ░ ░ X X ░ ░ ░                     *");
            Console.WriteLine("*                    11 ░ ░ X X X X X ░ ░ ░ X X ░ ░ ░                     *");
            Console.WriteLine("*                    12 ░ ░ ░ ░ ░ ░ X ░ ░ ░ X X ░ ░ ░                     *");
            Console.WriteLine("*                    13 ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░                     *");
            Console.WriteLine("*                    14 ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░                     *");
            Console.WriteLine("*                    15 ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));



            Console.ReadLine();
        }
    }
}