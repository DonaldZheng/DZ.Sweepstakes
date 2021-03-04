using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager: ISweepStakesManager // stack is Last in First Out //push and pop
        // ISweepStakesManager allows the SweepstakesStackManager to use Insert and Get Sweepstake in this class (same in the queue class)
    {
        //member variables
        private Stack<Sweepstakes> sweepstakeStack = new Stack<Sweepstakes>();

        //ctor

        // member methods 
        public void InsertSweepstake(Sweepstakes sweepstakes)
        {
            sweepstakeStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakeStack.Pop();
        }
    }
}
