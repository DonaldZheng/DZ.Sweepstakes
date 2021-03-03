using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string EnterFirstName()
        {
            Console.WriteLine("Enter your first name: ");
            return Console.ReadLine();
        }
        public static string EnterLastName()
        {
            Console.WriteLine("Enter your last name: ");
            return Console.ReadLine();
        }
        public static string EnterEmailAddress()
        {
            Console.WriteLine("Enter your email address:  ");
            return Console.ReadLine();
        }
        public static int EnterRegistrationNumber()
        {
            
            Console.WriteLine("Enter your registration number :");
            return null;
        }
    }
}
