using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class Prediction
    {
        public bool TempCalendarRes { get; set; }
        public Prediction(bool tempCalendarRes)
        {
            this.TempCalendarRes = tempCalendarRes;
        }
      
        public string SearchPredict()
        {
            Print print = new Print(new ConsolePrinter());

            if (TempCalendarRes)
            {
                Random random = new Random();
                int valueRnd = random.Next(1, 20);
                string mesPredict = Properties.Prediction.ResourceManager.GetString("Prediction" + valueRnd);
                return mesPredict;
            }
            else
            {
                print.PrintError();
                return null;
            }
        }
    }
}
