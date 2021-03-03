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
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        //Member methods
        public Sweepstakes CreateSweepstake(string name)
        {
            Sweepstakes sweepstake = new Sweepstakes(name);
            return sweepstake;
        }
    }
}
