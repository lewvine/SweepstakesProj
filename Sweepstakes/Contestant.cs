using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //Member variables
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        //Constructor
        public Contestant(string first, string last, string email)
        {
            this.FirstName = first;
            this.LastName = last;
            this.EmailAddress = email;
         }
    }
}
