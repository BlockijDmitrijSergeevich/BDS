using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Allocation
{
    public class Node
    {
        public bool IsFree { get; set; }
        public uint Address { get; set; }
        public int CountSegments { get; set; }
    }
}
