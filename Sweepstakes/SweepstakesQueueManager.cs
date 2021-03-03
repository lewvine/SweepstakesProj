using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager
    {
        //Member variables
        private Queue<Sweepstakes> queue;

        //Constructor
        public SweepstakesQueueManager(Queue<Sweepstakes> queue)
        {
            this.queue = queue;
        }
        //Member methods

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
