using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class EncodeEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
