using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Post
    {
        private static int currentPostId;

        //props
        //protected - only used by this class or deriving classes
        protected int PostId { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class does not invoke a base-class constructor explicitly
        //the default is used implicitly
        public Post()
        {
            PostId = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Austin";
        }

        //instance constructor
        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.PostId = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.PostId} - {this.Title} - {this.SendByUsername}");
        }


    }
}
