using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void SendMessage(object obj, EncodeEventArgs e)
        {
            Console.WriteLine("Sending message... to => " + e.Video.Title);
        }
    }
}
