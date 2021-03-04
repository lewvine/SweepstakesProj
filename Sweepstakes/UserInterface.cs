using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
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
