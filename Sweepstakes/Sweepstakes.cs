using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //Member variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get { return name; } }

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Member methods
        public void RegisterContestant(Contestant contestant)
        {
            //This setup does limit the contestant to one sweepstakes at a time.
            contestant.RegistrationNumber = contestants.Count;

            contestant.FirstName = UserInterface.GetUserInputFor("What is your first name?");
            contestant.LastName = UserInterface.GetUserInputFor("What is your last name?");
            contestant.EmailAddress = UserInterface.GetUserInputFor("What is your email?");
            PrintContestantInfo(contestant);
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            int winningNumber = rand.Next(1, contestants.Count - 1);
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(contestant.Key == winningNumber)
                {
                    return contestant.Value;
                }
            }
            //Whats the right way here?
            return null;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.ShowContestantInfo(contestant);
        }
    }
}
