using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA
{
    static class IOF
    {
        public static string ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
                return sr.ReadToEnd();
        }
    }
}
