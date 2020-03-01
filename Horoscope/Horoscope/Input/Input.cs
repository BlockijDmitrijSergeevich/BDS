using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horoscope.Interface;

namespace Horoscope.Input
{
    class Input
    {
        public IInput In { get; set; }
        public Input(IInput input)
        {
            this.In = input;
        }
        public string ReadLine()
        {
            return In.ReadLine();
        }        
    }
}
