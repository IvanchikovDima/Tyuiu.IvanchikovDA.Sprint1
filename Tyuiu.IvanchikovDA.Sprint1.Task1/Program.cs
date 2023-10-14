﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint1.Task1.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил Иванчиков Д. А.| ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода  в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Иванчиков Дмитрий Александрович | ПКТБ-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле (x*Pi)/(2*a) и печатает его на экране.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, a;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, a));

            Console.ReadLine();
        }
    }
}
