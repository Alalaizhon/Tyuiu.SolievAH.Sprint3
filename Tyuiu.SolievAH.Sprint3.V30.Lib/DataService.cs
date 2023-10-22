﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SolievAH.Sprint3.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            int i = 1;
            while (i <= 12)

            {
               res += (Math.Pow(value,i) + (5 / (i+4)))* Math.Sin(value);
                i++;
            }

            return Math.Round(res, 3);  
        }
    }
}