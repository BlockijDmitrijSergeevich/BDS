using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class Prediction
    {
        readonly IOF iOF = new IOF(Properties.File.Predict);
        public Prediction() { }

        public string SearchPredict()
        {
            Print print = new Print(new ConsolePrinter());
            try
            {
                Random random = new Random();
                int valueRnd = random.Next(1, 20);
                string[] predict = iOF.IOPredict();
                string mesPredict = predict[valueRnd - 1];
                return mesPredict;
            }
            catch
            {
                print.PrintAnswer(Properties.Menu.PrintError);
                return null;
            }
        }
    }
}
