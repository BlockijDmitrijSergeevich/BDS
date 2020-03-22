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
        public string Path { get; set; }
        public IOF(string path)
        {
            this.Path = path;
        }
        
        public string[] IOPredict()
        {
            string tempPath = ReadAll(Path);
            string[] predict = tempPath.Split(new char[] { '\n' });
            return predict;
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
