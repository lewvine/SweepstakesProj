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
        public int contestantCount;
        public string Name { get; set;}

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;        
        }

        //Member methods
        public void RegisterContestant(Contestant contestant)
        {
            //This setup does limit the contestant to one sweepstakes at a time.
            contestantCount++;
            contestant.RegistrationNumber = contestantCount;
            contestants.Add(contestant.RegistrationNumber, contestant);

        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            int winningNumber = rand.Next(1, contestantCount - 1);
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(contestant.Key == winningNumber)
                {
                    return contestant.Value;
                }
            }
            return null;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"");
        }
    }
}
