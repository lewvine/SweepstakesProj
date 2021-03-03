using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        //Methods
        int userInput;
        public void PromptType()
        {
            Console.WriteLine("Welcome to Sweepstakes Manager!  Would you like to utlize " +
                "a 'stack' or a 'queue' to keep track of your sweepstakes?  " +
                "Type '1' for 'stack' or '2' for 'queue'");
            userInput = Convert.ToInt32(Console.ReadLine());
        }

        public void SweepstakesManagerFactory()
        {
            ISweepstakesManager manager = null;
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
