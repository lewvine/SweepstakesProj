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
        public string Name { get; set;}

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;        
        }

        //Member methods
        public void RegisterContestant(Contestant contestant)
        {
            //DO SOMETHING
        }

        public Contestant PickWinner()
        {
            //DO SOMETHING
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"");
        }
    }
}
