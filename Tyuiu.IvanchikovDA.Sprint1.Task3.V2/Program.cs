using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook = 2.0;
            int amountNotebook = 3;
            double pricePencil = 6.0;
            int amountPencil = 8;

            Console.WriteLine("Цена тетрадей =" + priceNotebook);
            Console.WriteLine("Количество тетрадей =" + amountNotebook);
            Console.WriteLine("Цена ручек =" + pricePencil);
            Console.WriteLine("Количество ручек =" + amountPencil);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма покупки =" + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
            Console.ReadKey();


        }
    }
}
