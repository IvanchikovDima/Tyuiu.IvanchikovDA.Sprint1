﻿using System;
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
            return (x * pi) / (2 * a);
        }
    }
}
