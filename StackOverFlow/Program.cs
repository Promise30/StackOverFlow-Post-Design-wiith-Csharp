using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("The Post", "A New York Times best selling book of the 21st century.");

            var _initialCount = post._voteCount;
            Console.WriteLine("Inital number of votes: {0}", _initialCount);

            post.UpVote();

            var _currentCount = post._voteCount;
            Console.WriteLine("Current number of votes: {0}", _currentCount);



            Console.ReadKey();

        }
    }
}
