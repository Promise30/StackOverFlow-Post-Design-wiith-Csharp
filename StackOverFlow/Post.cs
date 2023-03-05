using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get;  } = DateTime.UtcNow;
        public int _voteCount {get; private set; } = 0;


        // Constructor
        public Post(string title, string description)
        {
            if(String.IsNullOrEmpty(title)) { throw new ArgumentNullException(nameof(title), "Title field is required"); }
            Title = title;
            Description = description;
            
            
        }

        public void UpVote()
        {
            if(_voteCount == -1 || _voteCount == 0)
            {
                _voteCount++;
            }
        }
        public void DownVote() 
        { 
            if(_voteCount == 0 || _voteCount == 1) 
            { 
                _voteCount--;
            }
        }

        
    }
}
