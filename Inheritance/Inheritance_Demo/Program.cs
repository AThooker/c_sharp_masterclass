using System;

namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post postOne = new Post("Thanks for the birthday wishes", "Austin", true);
            Post postTwo = new Post("Thanks for the birthday wishes", "Tim", true);
            Console.WriteLine(postOne.ToString());
            Console.WriteLine(postTwo.ToString());
            ImagePost image = new ImagePost("Check out my new shoes", "Austin", "https://images.com/shoes", true);
            Console.WriteLine(image.ToString());
            VideoPost video = new VideoPost("Check out my new video", "Austin",true, "https://videos.com/shoes", 25.0);
            Console.WriteLine(video.ToString());
            //Console.WriteLine("Press any key to start the video");
            //Console.ReadKey();
            //video.Play();
            //Console.WriteLine("Press any key to stop the video");
            //Console.ReadKey();
            //video.Stop();
            video.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            video.Stop();
        }
    }
}
