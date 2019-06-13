using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Stack manager gets the Sweepstakes");
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Stack manager inserts the sweepstakes");

        }

        Stack<int> stack = new Stack<int>();

        public void RegisterContestant(Contestant contestant)
        {

            contestant.RegistrationNumber = stack.Count + 1;
            stack.Push(contestant.RegistrationNumber);
            stack.Push(contestant.RegistrationNumber);
            stack.Push(contestant.RegistrationNumber);
            stack.Push(contestant.RegistrationNumber);
            stack.Push(contestant.RegistrationNumber);
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

