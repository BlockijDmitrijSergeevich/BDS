using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Memory
{
    public class Dump : IDump, IMemoryArea
    {
        private Segment[] segments = null;
        public IEnumerable<Segment> Segments => segments;

        public int Capacity => segments.Length * Segment.size / 1024;
        public int CountSegments => segments.Length;
        public bool IsEmpty => segments == null;

        public byte this[int i]
        {
            get => segments[(i / Segment.size)][i % Segment.size];
            set => segments[(i / Segment.size)][i % Segment.size] = value;
        }
        public byte this[int i, int j]
        {
            get => segments[i][j];
            set => segments[i][j] = value;
        }

        public Dump(uint kBytes)
        {
            Reallocate(kBytes);
        }

        public uint Allocate(uint address, byte[] bytes)
        {
            return Allocate((int)(address / (uint)Segment.size), bytes);
        }
        public uint Allocate(int offset, byte[] bytes)
        {
            int countSegments = CountOfSegments(bytes.Length);
            int currentByte = 0;

            for (int i = offset; i < countSegments + offset; i++)
            {
                var segment = segments[i];

                for (int j = 0; j < Segment.size; j++)
                {
                    segment[j] = bytes[currentByte++];

                    if (currentByte >= bytes.Length)
                        return segment.Adress;
                }
            }
            return 0x0000;
        }

        public void Reallocate(uint kBytes)
        {
            uint offset = 0x0000;

            segments = new Segment[kBytes * 1024 / Segment.size];
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i] = new Segment(offset);

                offset += 0x0001 * (uint)Segment.size;
            }
        }

        public static int CountOfSegments(int countBytes)
        {
            return (int)Math.Ceiling((double)countBytes / Segment.size);
        }
    }
}
