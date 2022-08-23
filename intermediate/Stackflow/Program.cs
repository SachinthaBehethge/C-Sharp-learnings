using System;

namespace Stackflow
{

    public class Stackover
    {
        //private string _title;
        //private string _desc;
        //private DateTime _createdAt;

        public string Title { set; get; }
        public string Desc { set; get; }

        public DateTime CreatedAt { get; } = DateTime.UtcNow;

        public int VoteCount { get; private set; } = 0;

        public Stackover(string title, string desc)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            Title = title;
            Desc = desc;
        }

        public void VoteUp()
        {
            switch (VoteCount)
            {
                case -1:
                case 0:
                    VoteCount += 1;
                    break;
            }
        }

        public void VoteDown()
        {
            switch (VoteCount)
            {
                case 0:
                case 1:
                    VoteCount -= 1;
                    break;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Stackover("post one", "post Description of this post");
            System.Console.WriteLine($"Title: {post.Title}");
            System.Console.WriteLine($"Description: {post.Desc}");
            System.Console.WriteLine($"Date Created: {post.CreatedAt}");
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteDown();
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteUp();
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
        }
    }
}