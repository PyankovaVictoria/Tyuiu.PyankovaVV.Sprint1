﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PyankovaVV.Sprint1.Task2.V12.Lib
{
    public class DataService : ISprint1Task2V12
    {
        public int CalculateParallelepipedVolume(int x, int y, int z)
        {
            return x * y * z;
        }
    }
}
