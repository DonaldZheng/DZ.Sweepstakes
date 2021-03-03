using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        // member variable 
        static int assignedNumber = 0;
        public static string EnterFirstName()
        {
            Console.WriteLine("Enter your first name: ");
            string userInputFirstName = Console.ReadLine();
            return userInputFirstName;
        }
        public static string EnterLastName()
        {
            Console.WriteLine("Enter your last name: ");
            string userInputLastName = Console.ReadLine();
            return userInputLastName;
        }
        public static string EnterEmailAddress()
        {
            Console.WriteLine("Enter your email address:  ");
            string userInputEmail = Console.ReadLine();
            return userInputEmail;
        }
        public static int EnterRegistrationNumber() // int not string here 
        {
            assignedNumber += 1; // ++ assignedNumber registration number is randomly assigned 
            Console.WriteLine("Your registation number is:" + assignedNumber);
            //int userInputNumber = Convert.ToInt32(Console.ReadLine());
            return assignedNumber;
        }
    }
}
