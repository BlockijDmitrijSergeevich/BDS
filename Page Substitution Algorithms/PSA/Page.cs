using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSA
{
    public class Page
    {
        static int indexer = 0;
        public int Index { get; private set; }
        public DateTime time { get; private set; }
        public int tact { get; private set; }

        public int Class
        {
            get
            {
                return 0 + (M ? 1 : 0) + (R ? 2 : 0);
            }
        }
        public bool R { get; private set; }
        public bool M { get; private set; }
        public Page()
        {
            tact = 0;
            time = DateTime.Now;
            indexer++;
            Index = indexer;
            R = false;
            M = false;
        }
        public void Read()
        {
            R = true;
        }
        public void Old()
        {
            tact++;
            R = false;
        }
        public void Save()
        {
            M = false;
        }
        public void Mod()
        {
            R = true;
            M = true;
        }
    }
}
