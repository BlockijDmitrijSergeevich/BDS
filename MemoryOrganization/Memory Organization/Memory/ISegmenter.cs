using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Memory
{
    public interface ISegmenter
    {
        IEnumerable<Segment> Segments { get; }

        int CountSegments { get; }
        int Capacity { get; }
    }
}
