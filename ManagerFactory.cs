using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    static class ManagerFactory
    {
        public static ISweepstakesManager ChooseManager(string managerType)
        {
            switch (managerType)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return null;
            }
        }
    }
}
