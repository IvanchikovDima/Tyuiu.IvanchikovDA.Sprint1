using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint1.Task2.Lib;


namespace Tyuiu.IvanchikovDA.Sprint1.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Иванчиков Д. А. | ПКТБ 23 - 1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1 *");
            Console.WriteLine("* Задание #2 *");
            Console.WriteLine("* Вариант #25 *");
            Console.WriteLine("* Выполнил: Иванчиков Дмитрий Александрович | ПКТБ-23-2                   *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите угол в радианах :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(x));

            Console.ReadLine();
        }
    }
}