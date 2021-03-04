using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //Methods
        //public static int ChooseSweepstakesManagerType()
        //{
        //    Console.WriteLine("Welcome to Sweepstakes Manager!  Would you like to utlize " +
        //        "a 'stack' or a 'queue' to keep track of your sweepstakes?  " +
        //        "Type '1' for 'stack' or '2' for 'queue'");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static void ShowContestantInfo(Contestant contestant)
        {
            Console.WriteLine(  $"Contestant #{contestant.RegistrationNumber}: " +
                                $"/rName: {contestant.FirstName} {contestant.LastName}" +
                                $"/rE-Mail: {contestant.EmailAddress}");
        }
    }

}
