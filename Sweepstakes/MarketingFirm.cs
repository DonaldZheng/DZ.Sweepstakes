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
        public MarketingFirm(ISweepStakesManager manager)
        {
            _manager = manager;
        }

        //member method 

        public void CreateSweepstake()
        {

        }

    }
}
