using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint2.Task3.V4.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя значения для x и   *");
            Console.WriteLine("* в зависимости от его значения вычисляет одну из следующих формул:       *");
            Console.WriteLine("*                    (x + 1)^x                                            *");
            Console.WriteLine("* при x > 1:    x + -----------                                           *");
            Console.WriteLine("*                    (x - 1)^x                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                  x^2 + cos(x^2)                                         *");
            Console.WriteLine("* при x = 0:    ---------------------                                     *");
            Console.WriteLine("*                x^2 - sin(x^2) + 12                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                           1                                             *");
            Console.WriteLine("* при -8 < x < 0:    (x - -----)^x                                        *");
            Console.WriteLine("*                          x^2                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                           1                                             *");
            Console.WriteLine("* при x < -8:    x + 10x - ---                                            *");
            Console.WriteLine("*                           x                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}