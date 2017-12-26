using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {

        public event EventHandler<EncodeEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoding started....");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        public void OnVideoEncoded(Video Video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new EncodeEventArgs() { Video = Video });
        }
    }
}
