using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#1 |Выполнил: Иванчиков Д.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Иванчиков Дмитрий Александрович | ПКТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
            Console.WriteLine("* является символьным представлением натурального числа                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите текст:                                                          *");
            string value = Convert.ToString(Console.ReadLine());

            bool res = ds.CheckNumber(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Строка является символьным представлением натурального числа.");
            }
            else
            {
                Console.WriteLine("Строка не является символьным представлением натурального числа.");
            }

            Console.ReadLine();
            Console.WriteLine("***************************************************************************");


            Console.ReadKey();
        }
    }
}
