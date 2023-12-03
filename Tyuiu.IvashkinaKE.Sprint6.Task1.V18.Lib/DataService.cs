﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IvashkinaKE.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((3 * x + 1.2) == 0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return valueArray;
        }
    }
}
