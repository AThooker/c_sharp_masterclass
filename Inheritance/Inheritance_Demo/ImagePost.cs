using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    //derive from Post, add proprerty URL, two constructors
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost(){}
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //all props inherited from Post class
            this.PostId = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //local property in imagePost class
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{this.PostId} - {this.Title} - {this.SendByUsername} - {this.ImageURL}");
        }
    }
}
