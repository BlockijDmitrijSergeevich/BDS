using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualExclusion
{
    class PetersonLock: IThreadLocker
    {
        bool[] want;
        int currentThread;
        public event EventHandler<LockEventArgs> OnCritical;
        public event EventHandler<LockEventArgs> OnNonCritical;

        public PetersonLock()
        {
            want = new bool[2];
            currentThread = 0;
        }
        public void Lock(int thread)
        {
            want[thread] = true;
            int other = 1 - thread;
            currentThread = thread;
            while (want[other] && currentThread == thread) ;
            OnCritical(this, new LockEventArgs() { ThreadID = thread });

        }
        public void Unlock(int thread)
        {
            want[thread] = false;
            OnNonCritical(this, new LockEventArgs() { ThreadID = thread });
        }
    }
}
