using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vote vote = new Vote();
            VoteScore voteScore = new VoteScore();



            vote.memberVote(voteScore.voting1(), voteScore.voting2(), voteScore.voting3(), voteScore.voting4(), voteScore.voting5());



        }
    }
}
