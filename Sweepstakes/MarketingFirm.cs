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
        private ISweepStakesManager _manager;

        //ctor
        public MarketingFirm(ISweepStakesManager manager) //dependant on ISweepstakeManager //   //pizza example: deep dish/stuff crust 
        {
            this._manager = manager;
        }
     
        //member method 

        public void CreateSweepstake() // create sweepstake object to add to manager 
        {
            Sweepstakes sweepstakes = new Sweepstakes("tickets");
            _manager.InsertSweepstake(sweepstakes);
        }
    }
}
