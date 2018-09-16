using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class VideoPost:Post
    {

        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;



        public string VideoURL { get; set; }
        public int VideoLength { get; set; }

        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, int videoLength, bool isPublic) {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.VideoLength = videoLength;
            this.IsPublic = isPublic;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Video Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0} seconds", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < VideoLength)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - video link: {3} - video length: {4} seconds", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.VideoLength);
        }
    }
}
