﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SolievAH.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for ( int j = 1; j <=i; j++)
                {
                    if (i%j == 0 || i%j == i)
                    {
                        res += j;
                    }

                }
                
            }
            return res;
        }
    }
}
