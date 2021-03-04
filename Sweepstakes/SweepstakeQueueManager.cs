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
        private Queue<Sweepstakes> sweepstakeQueue = new Queue<Sweepstakes>();
        //ctor

        //member methods 
        public void InsertSweepstake(Sweepstakes sweepstakes)
        {
            sweepstakeQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakeQueue.Dequeue();
        }
    }
}

