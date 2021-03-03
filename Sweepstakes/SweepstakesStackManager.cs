using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Member variables
        private Stack<Sweepstakes> stack;

        //Constructor
        public SweepstakesStackManager(Stack<Sweepstakes> stack)
        {
            this.stack = stack;
        }
        //Member methods

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
