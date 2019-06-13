using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            SweepstakesQueueManager manager = new SweepstakesQueueManager();
            MarketingFirm marketingFirm = new MarketingFirm(manager);


        }
    }
}
