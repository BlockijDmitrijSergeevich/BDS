using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Memory
{
    public interface IDump : IMemoryArea, ISegmenter
    {
        bool IsEmpty { get; }

        uint Allocate(uint address, byte[] bytes);
        uint Allocate(int offset, byte[] bytes);

        void Reallocate(uint kBytes);
    }
}
