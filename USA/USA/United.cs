﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA
{
    class United
    {
        public List<State> States { private set; get; }
        public United(State[] states)
        {
            States = new List<State>();
            States.AddRange(states);
        }
        public void TwittLoc(Twitt twitt)
        {
            foreach (var s in States)
            {
                if (s.InState(twitt.Point))
                    s.AddTwitts(twitt);
            }
        }
    }
}