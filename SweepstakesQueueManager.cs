using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    public class SweepstakesQueueManager:ISweepstakesManager
    {
        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }


        //uses the Queue data structure as underlying structure
        public void EnqueueOnQueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Elements in queue: ");
            foreach (int number in queue)
            {
                Console.WriteLine(number);
            }

            int startOfQueue = queue.Dequeue();

            queue.Enqueue(92);

            Console.WriteLine("Elements in queue after Dequeue and Enqueue(92): ");
            foreach (int number in queue)
            {
                Console.WriteLine(number);
            }
        }


    }
}
