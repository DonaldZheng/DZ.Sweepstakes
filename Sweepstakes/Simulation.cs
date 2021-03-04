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

        public static string ManagerChoice(string choice)//factory design video -Michael to reference this, switch case for ManagerChoice, parameter is the string choice 
        {
            ISweepStakesManager _manager;

            switch (choice)
            {
                case "Stack":
                    _manager = new SweepstakesStackManager();
                    break;
                case "Queue":
                    _manager = new SweepstakeQueueManager();
                    break;

                default:
                    Console.WriteLine("Not a valid choice, choose either Stack or Queue");
                    break;
            }
            return choice;
        }

    }
}
