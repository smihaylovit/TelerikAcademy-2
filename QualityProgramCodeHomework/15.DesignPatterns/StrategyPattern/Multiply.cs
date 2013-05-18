﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Multiply : IStrategy
    {
        public int Execute(int first, int second)
        {
            return first * second;
        }
    }
}
