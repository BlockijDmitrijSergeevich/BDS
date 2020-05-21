using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Organization.Allocation
{
    public interface IReservator
    {
        uint ReserveArea(int size);
    }
}
