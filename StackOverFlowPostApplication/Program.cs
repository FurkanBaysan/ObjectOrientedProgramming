using System;

namespace StackOverFlowPostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post(0);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine("Post Vote: " + post.FetchCurrentVoteNumberOfPost());
            post.DownVote();
            post.DownVote();
            Console.WriteLine("Post Vote: " + post.FetchCurrentVoteNumberOfPost());
        }
    }
}
