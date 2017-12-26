using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var Video = new Video() { Title = "Ram" };
            var VideoEncoder = new VideoEncoder();

            var MailService = new MailService();
            var MessageService = new MessageService();
            VideoEncoder.VideoEncoded += MailService.SendMail;
            VideoEncoder.VideoEncoded += MessageService.SendMessage;

            VideoEncoder.Encode(Video);
            Console.ReadKey();
        }
    }
}
