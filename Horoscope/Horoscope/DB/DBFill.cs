using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope.DB
{
    class DBFill
    {
        public static void MainDb()
        {
            using (var context = new MyDb())
            {
                var weather = new TableWeather()
                {
                    Weather = "Test1",
                };
                context.TableWeather.Add(weather);
                context.SaveChanges();
                var predict = new TablePredict()
                {
                    Predict = "Test2",
                };
                context.TablePredict.Add(predict);
                context.SaveChanges();
            }
        }
    }
}
