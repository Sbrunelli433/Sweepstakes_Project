using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    class UserInterface 
    {
        public string First_Name()
        {
            Console.WriteLine("Please enter your first name ");
            return Console.ReadLine ();
        }
        public string Last_Name()
        {
            Console.WriteLine("Please enter your last name ");
            return Console.ReadLine();
        }
        public string Email()
        {
            Console.WriteLine("please enter your email address ");
            return Console.ReadLine();
        }
    }
}
