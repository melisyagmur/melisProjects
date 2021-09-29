using System;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            post.UpVote();
            post.UpVote();
          
            Console.WriteLine(post.Vote);
        }
    }
}
