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
        Random random; // example in the war game project
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
            random = new Random();
        }

        //member method
        public void RegisterContesant(Contestant contestant) // get all the contesant info // reference soda machine?
        {
            contestant.firstName = UserInterface.EnterFirstName();
            contestant.lastName = UserInterface.EnterLastName();
            contestant.emailAddress = UserInterface.EnterEmailAddress();
            contestant.registrationNumber = UserInterface.GetRegistrationNumber();
        }

        public Contestant PickWinner() // will return the object: of the winner, look at RPSLS project 
        {
            Random random = new Random(); // randomly pick the winner 
            int index = random.Next();      // next returns a random int
            
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
