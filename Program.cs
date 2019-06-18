using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What sweepstakes manager would you like to use? Stack? or Queue?");
            string userInput = Console.ReadLine();
            ISweepstakesManager managerType = ManagerFactory.ChooseManager(userInput);
            MarketingFirm marketingFirm = new MarketingFirm(managerType);



            UserInterface.GetString("Please enter your first name");

        }
    }
}


