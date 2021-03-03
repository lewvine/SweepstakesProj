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
            int managerType = UserInterface.ChooseSweepstakesManagerType();
            SweepstakesManagerFactory(managerType);
        }

        public void SweepstakesManagerFactory(int userInput)
        {
            //Create a null instance.
            ISweepstakesManager manager = null;

            //Assign a derived class based on user input
            if (userInput == 1)
            {
                manager = new SweepstakesStackManager();
            }
            else if (userInput == 2)
            {
                manager = new SweepstakesQueueManager();
            }
        }
    }
}
