using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Allocation
{
    public interface IAllocator
    {
        IEnumerable<Node> Nodes { get; }
    }
}
