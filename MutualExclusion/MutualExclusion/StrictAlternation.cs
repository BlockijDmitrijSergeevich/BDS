using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualExclusion
{
    class StrictAlternation: IThreadLocker
    {
        int currentThread = 0;
        public event EventHandler<LockEventArgs> OnCritical;
        public event EventHandler<LockEventArgs> OnNonCritical;
        public void Lock(int thread)
        {
            while (currentThread != thread) ;
            OnCritical(this, new LockEventArgs() { ThreadID = thread });

        }

        public void Unlock(int thread)
        {
            currentThread = 1 - thread;
            OnNonCritical(this, new LockEventArgs() { ThreadID = thread });
        }
    }
    class LockEventArgs : EventArgs
    {
        public int ThreadID { get; set; }
    }
}
