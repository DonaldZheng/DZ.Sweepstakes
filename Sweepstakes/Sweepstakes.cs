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
        private string name;
        public int winnerNumber;
        public Dictionary<int, Contestant> contestantDictionary = new Dictionary<int, Contestant>();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
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
            contestant.registrationNumber = UserInterface.GetRegistrationNumber();
        }

        public string PickWinner() // will return a string of the winner, look at RPSLS project 
        {
            Random random = new Random(); // randomly pick the winner 
            winnerNumber = random.Next();      // next returns a random int
            foreach (Dictionary<int, string> contestant in nameDictionary)
            {
                if (contestant == winnerNumber) // contestant number is equal to the winner number
                {
                }
            }
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
