using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            Console.WriteLine("Write a short blog post.");
            post.getDescription(Console.ReadLine());

            post.getVote(1);
            post.getVote(1);
            post.getVote(1);
            Console.WriteLine("Your post has {0} votes", post.getVote(-1));
        }
    }

    public class Post
    {
        private string Description { get; set; }
        private int Votes { get; set; }
        private DateTime _postTime;

        public string getDescription(string text)
        {
            _postTime = DateTime.Now;
            Description = text + "\n" + _postTime;
            
            return Description;
        }

        public int getVote(int vote)
        {
            Votes += vote;

            return Votes;
        }
    }
}
