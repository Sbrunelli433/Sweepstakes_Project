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
            SweepstakesQueueManager manager = new SweepstakesQueueManager();
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            //MarketingFirm marketingFirm = new MarketingFirm(stackManager);

            int choice;
            int data;
            while (true)
            {
                Console.WriteLine("choose sweepstakes manager type");
                Console.WriteLine("1. Stack manager");
                Console.WriteLine("2. Queue manager");

                choice = int.Parse(Console.ReadLine());
                if (choice == 3)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        data = int.Parse(Console.ReadLine());
                        SweepstakesStack();
                        break;
                    case 2:
                        data = int.Parse(Console.ReadLine());
                        SweepstakesQueue();
                        break;
                }

                public void SweepstakesStack()
                {
                    MarketingFirm marketingFirm = new MarketingFirm(stackManager);
                }
                public void SweepstakesQueue()
                {
                    MarketingFirm marketingFirm = new MarketingFirm(manager);
                }
            }
        }
    }
}
