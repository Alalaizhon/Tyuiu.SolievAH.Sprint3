using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SolievAH.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double t = Convert.ToDouble(value);
            double i = Convert.ToDouble(startValue);
            double res = 1;
            do
            {
                res *= Math.Pow(t, i) + (1/ (i + 1));
                i++;
            } while (i <= 13);

            return res ;
        }
    }
}
