﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Cocksick
    {
        public double Weight { get; set; }
        public double PercentZola { get; set; }
        public double PercentSera { get; set; }
        public double PercentValotiles { get; set; }
        public double PercentC => 100 - (PercentZola + PercentSera + PercentValotiles);
    }
}
