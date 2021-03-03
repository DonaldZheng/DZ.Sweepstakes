using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    // use dictionary data strcuture as an underlying structure: Dictionary<TKey,TValue>
    class Sweepstakes
    {
        //member variable 
        public string name;
        public int winnerNumber;
        public Dictionary<int, string> nameDictionary = new Dictionary<int, string>();
        public Dictionary<int, string> emailAddressDictionary = new Dictionary<int, string>(); // do not need a reg number dictionary?

        //ctor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //member method
        public void RegisterContesant(Contestant contestant) // get all the contesant info 
        {
            contestant.firstName = UserInterface.EnterFirstName();
            contestant.lastName = UserInterface.EnterLastName();
            contestant.emailAddress = UserInterface.EnterEmailAddress();
            contestant.registrationNumber = UserInterface.EnterRegistrationNumber();
        }

        public string PickWinner() // will return a string of the winner, look at RPSLS project 
        {
            Random random = new Random(); // randomly pick the winner 
            winnerNumber = random.Next()
            return null;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant Name: " + contestant.firstName + contestant.lastName);
            Console.WriteLine("Contestant Email Address: " + contestant.emailAddress);
            Console.WriteLine("Contestant Registration Number: " + contestant.registrationNumber);
           
        }





    }
}
