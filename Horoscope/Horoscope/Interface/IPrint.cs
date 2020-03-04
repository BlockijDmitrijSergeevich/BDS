using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope.Interface
{
    interface IPrint
    {
        void PrintAnswer(string text);
        void PrintMenu(string text);
        void PrintEx1(string text);
        void PrintEx1PeriodChoise(string text);
    }
}
