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
        private Contestant winner;
        public string Name { get { return name; } }
        public Contestant Winner
        {
            get { return winner; }
            set { winner = value; NotifyConstestants(); }
        }

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
                    winner = contestant.Value;
                }
            }
            //Alert all the other contestants a winner has been selected
            NotifyConstestants();
            return winner;
        }

        public void NotifyConstestants()
        {
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(contestant.Value == winner)
                {
                    Console.WriteLine($"Congratulations, {winner.FirstName} for winning the {this.name} Sweepstakes!");
                }
                else
                {
                    Contestant loser = contestant.Value;
                    Console.WriteLine($"Hey {loser.FirstName} {loser.LastName}!  We've selected a " +
                        $"winner for {this.name}: {winner.FirstName}.  ");
                }
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.ShowContestantInfo(contestant);
        }
    }
}
