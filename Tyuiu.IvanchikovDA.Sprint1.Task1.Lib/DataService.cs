using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;



namespace Tyuiu.IvanchikovDA.Sprint1.Task1.Lib
{
    public class DataService : ISprint1Task1V23
    {
        public double Calculate(double a, double x)
        {
            return Math.Round((x * (Math.PI)) / (2 * a),2);
        }
    }
}

//(x * Pi) / (2 * a)
//(100 * (x * (Math.PI)) / (2 * a)) / 100;