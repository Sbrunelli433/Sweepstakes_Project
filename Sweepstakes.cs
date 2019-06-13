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
            ContestantData.Add(contestant.RegistrationNumber, contestant);
            ContestantData.Add(contestant.RegistrationNumber, contestant);
            ContestantData.Add(contestant.RegistrationNumber, contestant);
            ContestantData.Add(contestant.RegistrationNumber, contestant);
           
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
