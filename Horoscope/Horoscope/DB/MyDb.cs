using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Horoscope.DB;

namespace Horoscope
{
    public class MyDb: DbContext
    {
        public MyDb() : base("DbConnection"){ }

        public DbSet<TableWeather> TableWeather { get; set; }

    }
}
