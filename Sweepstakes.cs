using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> ContestantData;
        public string name;

        public Sweepstakes(string name)
        {
            ContestantData = new Dictionary<int, Contestant>();
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = ContestantData.Count + 1;
            ContestantData.Add(contestant.RegistrationNumber, contestant);  
        }

        public string PickWinner()
        {
            Random rng = new Random();
            // count of dictionary
            int registrationNum = rng.Next(1, ContestantData.Count);
            Contestant contestantWinner;
            contestantWinner = ContestantData[registrationNum];
            return contestantWinner.FirstName + contestantWinner.LastName + contestantWinner.EmailAddress;
            // once we have the winning reg num
            // get THAT contestant out of dictinoary
            // ContestantData[6];

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Sweepstakes winner's first name is " + contestant.FirstName);
            Console.WriteLine("Winner's last name is " + contestant.LastName);
            Console.WriteLine("Winner's email address is " + contestant.EmailAddress);
        }
    }
}
