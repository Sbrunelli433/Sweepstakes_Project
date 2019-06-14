using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Queue Manager gets the sweepstakes");
            return queue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Queue Manager inserts the sweepstakes");
            queue.Enqueue(sweepstakes);
        }

        //uses the Queue data structure as underlying structure


    }
}

