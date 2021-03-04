using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakeQueueManager : ISweepStakesManager //First In First Out // Enqueue and dequeue
    {
        //member variables
        Queue<Sweepstakes> myStack = new Queue<Sweepstakes>();
        //ctor

        //member methods 
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return null;
        }
    }
}

