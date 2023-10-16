using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint1.Task4.V30.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("(x+y^3) / e^2−y                                                            ");

            int x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" (x + y^3) / e^2 − y = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
