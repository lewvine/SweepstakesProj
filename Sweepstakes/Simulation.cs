using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation
    {
        public void RunSimulation()
        {
            MarketingFirm firm = CreateMarketingFirmWithManager();
            Sweepstakes newCarSweepstake = firm.CreateSweepstake("Win a BRAND, NEW CAAAR!");
            Contestant calWorthington = new Contestant("Cal", "Worthington", "cal.worthington@dodge.com");
            Contestant joeDirte = new Contestant("Joe", "Dirte", "joe.dirte@gmail.com");
            newCarSweepstake.RegisterContestant(calWorthington);
            newCarSweepstake.RegisterContestant(joeDirte);


        }

        public MarketingFirm CreateMarketingFirmWithManager()
        {
            int userSelection = UserInterface.ChooseSweepstakesManagerType();
            ISweepstakesManager manager = SweepstakesManagerFactory(userSelection);

            MarketingFirm firm = new MarketingFirm(manager);
            return firm;
        }

        public ISweepstakesManager SweepstakesManagerFactory(int userInput)
        {
            //Assign a derived class based on user input
            if (userInput == 1)
            {
                return new SweepstakesStackManager();
            }
            else if (userInput == 2)
            {
                return new SweepstakesQueueManager();
            }
            else
            {
                Console.WriteLine("You have not selected the correct input.");
                return null;
            }
        }


    }
}
