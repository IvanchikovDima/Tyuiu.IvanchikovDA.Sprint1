using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanchikovDA.Sprint1.Task7.V24.Lib
{
    public class DataService : ISprint1Task7V24
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((Math.Sin(x * x) + y) / (y + 1)) - ((x * y - 12) / (34 + x * x)), 3);
        }
    }
}
 