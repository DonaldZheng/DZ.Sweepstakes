using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager: ISweepStakesManager // stack is Last in First Out //push and pop
    {
        //member variables
        Stack<Sweepstakes> myStack = new Stack<Sweepstakes>();

        //ctor

        // member methods 
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return null;
        }
    }
}
