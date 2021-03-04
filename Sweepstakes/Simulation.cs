using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            SweepstakesStackManager Stack = new SweepstakesStackManager();
            MarketingFirm firm = new MarketingFirm(Stack);
            firm.CreateSweepstake();
        }

        public void ManagerChoice(string choice)
        {
            //switch case for ManagerChoice
            //parameter is the string choice 
        }
        //factory design video 
    }
}
