using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Memory
{
    public interface IMemoryArea
    {
        int Capacity { get; }

        byte this[int i] { get; set; }
        byte this[int i, int j] { get; set; }
    }
}
