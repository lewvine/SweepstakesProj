using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //Member variables
        private ISweepstakesManager _manager;

        //Constructor
        //The dependency is injected in the simulation class and passes through here.  The use of the interface
        //ISweepstakes manager enables a decision about what specific class utilizing the interface the manager
        //will be to be made on the UI side, later.  This set up is flexible.  Nothing in the program depends
        //on which specific choice is selected.  It also allows for extension of sweepstakes manager types later,
        //so long as they utilize the methods found in the interface.
        public  MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        //Member methods
        public void CreateSweepstake(string name)
        {
            Sweepstakes sweepstake = new Sweepstakes(name);
            _manager.InsertSweepstakes(sweepstake);
        }
    }
}
