﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IvashkinaKE.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
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
                if ((Math.Sin(x) + 1) == 0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = (2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1));
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return valueArray;
        }
    }
}
