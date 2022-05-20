using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPostApplication
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public int Vote { get; private set; }

        public Post(int vote)
        {
            this.Vote = vote;
        }

        public void UpVote()
        {
            this.Vote = this.Vote + 1;
        }

        public void DownVote()
        {
            if (this.Vote > 0)
            {
                this.Vote = this.Vote - 1;
            }
            else
                throw new InvalidOperationException();
        }

        public int FetchCurrentVoteNumberOfPost()
        {
            return this.Vote;
        }



    }
}
