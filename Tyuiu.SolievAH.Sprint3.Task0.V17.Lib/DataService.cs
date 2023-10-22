using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SolievAH.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res = Math.Cos(i) * 0.5;
            }
            return Math.Round(res, 3);
        }
    }
}
