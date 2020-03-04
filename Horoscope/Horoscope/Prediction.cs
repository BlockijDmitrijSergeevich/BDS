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
        public bool TempCalendarResPred { get; set; }
        public Prediction(bool tempCalendarRes, bool tempCalendarResPred)
        {
            this.TempCalendarRes = tempCalendarRes;
            this.TempCalendarResPred = tempCalendarResPred;
        }
      
        public string SearchPredict()
        {
            Print print = new Print(new ConsolePrinter());

            if (TempCalendarRes && TempCalendarResPred)
            {
                Random random = new Random();
                int valueRnd = random.Next(1, 20);
                string mesPredict = Properties.Prediction.ResourceManager.GetString("Prediction" + valueRnd);
                return mesPredict;
            }
            else
            {
                print.PrintAnswer(Properties.Menu.PrintError);
                return null;
            }
        }
    }
}
