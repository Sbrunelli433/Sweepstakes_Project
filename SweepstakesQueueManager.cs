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
            Console.WriteLine("Queue Manager gets the sweepstakes");
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Queue Manager inserts the sweepstakes");
        }

        //uses the Queue data structure as underlying structure

        Queue<int> queue = new Queue<int>();

        public void RegisterContestant(Contestant contestant)
        {

            contestant.RegistrationNumber = queue.Count + 1;
            queue.Enqueue(contestant.RegistrationNumber);
            queue.Enqueue(contestant.RegistrationNumber);
            queue.Enqueue(contestant.RegistrationNumber);
            queue.Enqueue(contestant.RegistrationNumber);
            queue.Enqueue(contestant.RegistrationNumber);
        }
        public string PickWinner(Contestant contestant)
        {
            Random rng = new Random();
            int registrationNum = rng.Next(1, contestant.RegistrationNumber);

            if (registrationNum == contestant.RegistrationNumber)
            {
                return contestant.FirstName;
            }
            else
            {
                return PickWinner(contestant);
            }
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Sweepstakes winner is.. " + PickWinner(contestant));
        }

        
        }


    }
}
