﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //Methods
        public static int ChooseSweepstakesManagerType()
        {
            Console.WriteLine("Welcome to Sweepstakes Manager!  Would you like to utlize " +
                "a 'stack' or a 'queue' to keep track of your sweepstakes?  " +
                "Type '1' for 'stack' or '2' for 'queue'");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int AddContestants()
        {
            Console.WriteLine(  "ADD A CONTESTANT: FIRST NAME/nPlease enter the contestant' first name.  Hit 'ENTER' when done.")
            Console.ReadLine();
                return Convert.ToInt32(Console.ReadLine());
        }
    }

}
