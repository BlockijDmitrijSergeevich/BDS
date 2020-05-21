using Memory_Organization.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Allocation
{
    public class Allocator : IAllocator, IReservator
    {
        public IEnumerable<Node> Nodes => areas;
        public readonly int offset = 0;

        public Allocator(int countSegments, int offset)
        {
            this.offset = offset;

            areas.Add(new Node()
            {
                IsFree = true,
                Address = 0x0001 * (uint)Segment.size,
                CountSegments = countSegments - 1
            });
        }

        public uint ReserveArea(int countSegments)
        {
            for (int i = 0; i < areas.Count; i++)
            {
                Node area = areas[i];
                if (area.IsFree && area.CountSegments >= countSegments)
                {
                    int newCountSegments = area.CountSegments - (countSegments + offset);

                    if (i == areas.Count - 1)
                    {
                        areas.Add(new Node()
                        {
                            IsFree = true,
                            Address = area.Address + (uint)((countSegments + offset) * Segment.size),
                            CountSegments = newCountSegments < 0 ? 0 : newCountSegments
                        });
                    }

                    area.IsFree = false;
                    area.CountSegments = countSegments;

                    return area.Address;
                }
            }

            return 0x0000;
        }

        public bool ClearArea(uint address)
        {
            Node node = areas.Single(x => x.Address == address);

            if (node != null)
            {
                node.IsFree = true;

                return true;
            }

            return false;
        }

        private List<Node> areas = new List<Node>();
    }
}
