﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA
{
    class State
    {
        public List<District> Districts { get; set; }
        public List<Twitt> Twitts { get; set; }
        public string Name { get; set; }
        public float Happy { get; set; }
        public string StateCoords { get; set; }
        public State(string name, string StateCoords)
        {
            this.Districts = new List<District>();
            this.Twitts = new List<Twitt>();
            this.Name = name;
            this.StateCoords = StateCoords;
            SplitState();
        }
        public void SplitState()
        {
            string[] DistictsCoords = StateCoords.Split(new string[] { "[[[", "]]]" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < DistictsCoords.Length; i++)
            {
                string[] StatesCoords = DistictsCoords[i].Split(new char[] { ',', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Point[] points = new Point[StatesCoords.Length / 2];
                for (int j = 0; j < StatesCoords.Length; j += 2)
                {
                    if (StatesCoords[j][1] >= '0' && StatesCoords[j][1] <= '9')
                        points[j / 2] = new Point(float.Parse(StatesCoords[j]), float.Parse(StatesCoords[j + 1]));
                }
                if (!(points.Length == 0))
                    Districts.Add(new District(points));
            }
        }
        public void AddTwitts(Twitt twitt)
        {
            if (twitt.TwittText == null)
                return;
            if (twitt.Happy != float.MaxValue)
                Happy = (Happy * Twitts.Count + twitt.Happy) / (Twitts.Count + 1);
            Twitts.Add(twitt);
        }
        public bool InState(Point point)
        {
            foreach (var d in Districts)
            {
                if (d.In(point))
                    return true;
            }
            return false;
        }
    }
}