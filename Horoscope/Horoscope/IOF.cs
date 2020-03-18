using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Horoscope
{
    class IOF
    {
        public string path { get; set; }
        public IOF(string path)
        {
            this.path = path;
        }
        
        public string[] IOPredict()
        {
            string tempPath = ReadAll(path);
            string[] sPath = tempPath.Split(new char[] { '\n' });
            return sPath;
        }

        private static string ReadAll(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
