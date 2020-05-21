using Memory_Organization.Allocation;
using Memory_Organization.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization
{
    class Manager
    {
        public ISegmenter Segmenter => dump;
        public IAllocator Allocator => allocator;
        //public IEnumerable<Node> Nodes => allocator.Nodes;
        public IEnumerable<Task> Tasks => tasks;

        public Manager()
        {

        }

        public bool AddTask(int bytes)
        {
            int countSegments = Dump.CountOfSegments(bytes);
            uint address = allocator.ReserveArea(countSegments);

            if (address != 0x0000)
            {
                tasks.Add(new Task()
                {
                    Offset = address,
                    Size = bytes
                });

                RandomFillChankMemory(address, bytes);

                return true;
            }

            return false;
        }
        public bool RemoveTask(int index)
        {
            if (index < tasks.Count && index >= 0)
            {
                Task task = tasks[index];
                allocator.ClearArea(task.Offset);

                ClearChankMemory(task.Offset, task.Size);

                tasks.RemoveAt(index);

                return true;
            }
            return false;
        }

        public void ResetMemory(uint kBytes)
        {
            dump = new Dump(kBytes);
            allocator = new Allocator(dump.CountSegments, 1);
            tasks = new List<Task>();
        }

        private void FillChankMemory(uint address, int bytes)
        {
            for (int i = (int)address; i < bytes + (int)address; i++)
            {
                dump[i] = 0xff;
            }
        }
        private void RandomFillChankMemory(uint address, int bytes)
        {
            for (int i = (int)address; i < bytes + (int)address; i++)
            {
                dump[i] = (byte)random.Next(0x00, 0xff + 1);
            }
        }
        private void ClearChankMemory(uint address, int bytes)
        {
            for (int i = (int)address; i < bytes + (int)address; i++)
            {
                dump[i] = 0x00;
            }
        }

        public bool CloneByte(int index, uint from, uint to)
        {
            if (from == to) return false;

            Task task = tasks[index];

            if (index < tasks.Count && index >= 0)
            {
                if(from < task.Size && to < task.Size)
                {
                    dump[(int)(to + task.Offset)] = dump[(int)(from + task.Offset)];

                    return true;
                }
            }

            return false;
        }

        private List<Task> tasks;
        private Allocator allocator;
        private IDump dump;
        private Random random = new Random();
    }
}
