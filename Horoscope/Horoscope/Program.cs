using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horoscope.Input;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Print print = new Print(new ConsolePrinter());
                Input.Input input = new Input.Input(new ConsoleInput());

                print.PrintMenu();
                int i = int.Parse(Console.ReadLine());
                do
                {
                    switch (i)
                    {
                        case 1:
                            { 
                                string tempData, tempPredict, tempPeriodBefor, tempPeriodAfter;
                                bool tempCalendarRes;

                                print.PrintEx1();
                                tempData = input.ReadLine();
                                Calendar calendar = new Calendar(tempData);
                                tempCalendarRes = calendar.ValidDate();
                                Prediction prediction = new Prediction(tempCalendarRes);
                                string res = prediction.SearchPredict();
                                print.PrintAnswer(res);

                                print.PrintEx1DatePrediction();
                                tempPredict = input.ReadLine();
                                Calendar calendarPredict = new Calendar(tempPredict);
                                tempCalendarRes = calendarPredict.ValidDate();
                                Prediction predictionData = new Prediction(tempCalendarRes);
                                string resData = predictionData.SearchPredict();
                                print.PrintAnswer(resData);

                                print.PrintEx1PeriodBefor();
                                tempPeriodBefor = input.ReadLine();
                                Calendar calPeriodBefor = new Calendar(tempPeriodBefor);
                                tempCalendarRes = calPeriodBefor.ValidDate();
                                print.PrintEx1PeriodAfter();
                                tempPeriodAfter = input.ReadLine();
                                Calendar calPeriodAfter = new Calendar(tempPeriodAfter);
                                tempCalendarRes = calPeriodAfter.ValidDate();
                                Prediction predictionPeriod = new Prediction(tempCalendarRes);
                                string resPeriod = predictionData.SearchPredict();
                                print.PrintAnswer(resData);

                                break;
                            }
                        case 2:
                            {
                                print.PrintEx2();
                                break;
                            }
                        case 3:
                            {
                                print.PrintEx3();
                                break;
                            }
                        case 0:
                            {
                                print.PrintLeave();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
