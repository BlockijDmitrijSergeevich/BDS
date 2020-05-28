using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope.DB
{
    public class DBFill
    {
        public DBFill()
        {
            MainDb();
        }
        public string MainDb()
        {
            using (var context = new MyDb())
            {                
                var apartments = context.TableWeather.Where(a => a.Id == 13);

                string res = null;
                foreach (var apart in apartments)
                {
                    return res = apart.Weather;
                }
                foreach (var apart in apartments)
                {
                    return res = apart.Horoscope;
                }
            }
            return null;
        }
    }
}
