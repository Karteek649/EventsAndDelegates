using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MailService
    {

        public void SendMail(object obj, EncodeEventArgs e)
        {
            Console.WriteLine("Sending Mail... to => " + e.Video.Title);
        }
    }
}
