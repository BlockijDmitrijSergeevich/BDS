using Memory_Organization.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization
{
    public class Task
    {
        public uint Offset { get; set; }
        public int Size { get; set; }

        public Task()
        {
            
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", Segment.AddressFormat(Offset), Size);
        }
    }
}
