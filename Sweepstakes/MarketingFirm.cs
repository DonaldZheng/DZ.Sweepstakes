using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variable
        private ISweepStakesManager _manager; //ISweepStakesManager is working here because it allows us to access the Queue and Stack Manager Class to use push/pop/queue/dequeue 
        

        //ctor
        public MarketingFirm(ISweepStakesManager manager) //pizza example: deep dish/stuff crust 
        {
            this._manager = manager;
        }
     
        //member method 

        public void CreateSweepstake() // create sweepstake object to add to manager 
        {
            Sweepstakes sweepstakes = new Sweepstakes("tickets");
            _manager.InsertSweepstake(sweepstakes); 

            // InsertSweepstake works here because it's inherited from the interface of ISweepstakesManager class. This allows the method 
            // to put the sweepstake object into the stack and queue manager.
        }
    }
}
