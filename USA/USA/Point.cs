
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA
{
    struct Point
    {
        public float X { set; get; }
        public float Y { set; get; }
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}