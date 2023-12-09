using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint1.Task7.V24.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 1. Выполнил: Иванчиков Д.А. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту      ");
            Console.WriteLine("* Задание #7                                                    ");
            Console.WriteLine("* Вариант #24                                                   ");
            Console.WriteLine("* Выполнил: Иванчиков Д.А. | ПКТб-23-1                          ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу, которая вычисляет математическое выражение по исходным " +
                "значениям данных, вводимых пользователем.Ответ округлите до 3 знаков после запятой.* ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Введите значение аргумента");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Значение функции: ");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
