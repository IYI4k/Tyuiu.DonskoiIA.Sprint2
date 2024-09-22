using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint2.Task0.V20.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая при параметрах x = 1075, y = 275 и с        *");
            Console.WriteLine("* помощью операций сравнений (==, !=, <, >, <=, >=, именно в таком        *");
            Console.WriteLine("* порядке) и арифметических выражений вернёт {true, false, true, false,   *");
            Console.WriteLine("* true, false}                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" x = 1075");
            Console.WriteLine(" y = 275");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            foreach (bool i in ds.GetCompareOperations(1075, 275))
            {
                Console.Write(i);
                Console.Write(' ');
            }

            

            Console.ReadLine();
        }
    }
}