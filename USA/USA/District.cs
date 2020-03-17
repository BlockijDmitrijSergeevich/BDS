﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA
{
    class District
    {
        public Point[] Points { get; set; }
        public District(Point[] points)
        {
            this.Points = points;
        }
        public bool In(Point point)
        {
            bool c = false;
            for (int i = 0, j = Points.Length - 1; i < Points.Length; j = i++)
            {
                if ((((Points[i].Y <= point.Y) && (point.Y < Points[j].Y)) || ((Points[j].Y <= point.Y) && (point.Y < Points[i].Y))) &&
                ((Points[j].Y - Points[i].Y) != 0) && (point.X > ((Points[j].X - Points[i].X) * (point.Y - Points[i].Y) / (Points[j].Y - Points[i].Y) + Points[i].X)))
                    c = !c;
            }
            return c;
        }
    }
}