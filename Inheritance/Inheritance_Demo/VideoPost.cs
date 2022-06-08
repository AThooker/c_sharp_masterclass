using System;
using System.Diagnostics;
using System.Threading;

namespace Inheritance_Demo
{
    class VideoPost : Post
    {
        protected bool isNotPlaying = true;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected double Length { get; set; }
        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, double length)
        {
            this.PostId = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
            VideoURL = videoURL;
            Length = length;
        }
        public override string ToString()
        {
            return String.Format($"{this.PostId} - {this.Title} - {this.SendByUsername} - {this.VideoURL}");
        }
        //Stopwatch watch = new Stopwatch();
        public void Play()
        {
            if (isNotPlaying)
            {
                isNotPlaying = false;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            //watch.Start();
        }
        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}");
                GC.Collect();
            }
        }
        public void Stop()
        {
            if (!isNotPlaying)
            {
                isNotPlaying = true;
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();
            }
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed.TotalSeconds);
        }
    }
}
