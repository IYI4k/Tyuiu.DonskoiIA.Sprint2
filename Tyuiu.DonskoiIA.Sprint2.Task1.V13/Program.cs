using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint2.Task1.V13.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task1.V13
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая при параметрах a = 145, b = 916, c = 164,   *");
            Console.WriteLine("* d = 137 с помощью логических операций (|, &, ||, &&, !, ^, именно в     *");
            Console.WriteLine("* таком порядке), арифметических выражений и операций сравнений (==, !=,  *");
            Console.WriteLine("* <, >, <=, >=, порядок неважен, в выражении нельзя использовать одну и   *");
            Console.WriteLine("* ту же операцию дважды) вернёт {true, true, true, true, true, false}     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" a = 145");
            Console.WriteLine(" b = 916");
            Console.WriteLine(" c = 164");
            Console.WriteLine(" d = 137");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            foreach (bool i in ds.GetLogicOperations(145, 916, 164, 137))
            {
                Console.Write(i);
                Console.Write(' ');
            }



            Console.ReadLine();
        }
    }
}