﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MalyshkinNR.Sprint1.Task2.V5.Lib
{
    public class DataService : ISprint1Task2V5
    {
        public int CalculateSideSquare(int a)
        {
            return 6 * (a * a);
        }
    }
}