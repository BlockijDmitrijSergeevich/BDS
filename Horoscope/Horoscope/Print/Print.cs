using Horoscope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class Print
    {
        public string Text { get; set; }
        public IPrint Printer { get; set; }

        public Print(IPrint printer)
        {
            this.Printer = printer;
        }
        public void PrintAnswer(string text)
        {
            Printer.PrintAnswer(text);
        }
        public void Clear()
        {
            Printer.Clear();
        }
        public void PrintMenu()
        {
            Printer.PrintMenu(Text);
        }
        public void PrintEx1()
        {
            Printer.PrintEx1(Text);
        }
        public void PrintPeriodChoise()
        {
            Printer.PrintPeriodChoise(Text);
        }
        public void PrintPeriodChoise2()
        {
            Printer.PrintPeriodChoise2(Text);
        }
        public void PrintChoisePeriodDate()
        {
            Printer.PrintChoisePeriodDate(Text);
        }
        public void PrintEx(Exception ex)
        {
            Printer.PrintEx(ex);
        }
    }
}
