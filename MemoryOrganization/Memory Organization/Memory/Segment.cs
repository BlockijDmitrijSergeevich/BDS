using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Memory
{
    public class Segment
    {
        public static int size = 8;
        public uint Adress { get; }

        public byte this[int i]
        {
            get => bytes[i];
            set => bytes[i] = value;
        }

        private byte[] bytes = new byte[size];

        public static string ByteFormat(byte val)
        {
            if (val < 0x10) return "0" + string.Format("{0:X}", val);
            return string.Format("{0:X}", val);
        }
        public static string AddressFormat(uint address)
        {
            if (address < 0x0010) return string.Format("0x000{0:X}", address);
            else if(address < 0x0100) return string.Format("0x00{0:X}", address);
            else if (address < 0x1000) return string.Format("0x0{0:X}", address);
            return string.Format("0x{0:X}", address);
        }

        public Segment(uint adress)
        {
            Adress = adress;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(AddressFormat(Adress)).Append('\t');

            foreach (var cell in bytes)
            {
                builder.Append(ByteFormat(cell));
            }
            builder.Append('\t');

            foreach (var cell in bytes)
            {
                switch ((char)cell)
                {
                    case '\0': builder.Append(' ').Append(' '); break;                    
                    case '\a': builder.Append(@"\a"); break;
                    case '\b': builder.Append(@"\b"); break;
                    case '\f': builder.Append(@"\f"); break;
                    case '\n': builder.Append(@"\n"); break;
                    case '\r': builder.Append(@"\r"); break;
                    case '\t': builder.Append(@"\t"); break;
                    case '\v': builder.Append(@"\v"); break;

                    default:
                        builder.Append((char)cell).Append(' ');
                        break;
                }
            }

            return builder.ToString();
        }
    }
}
