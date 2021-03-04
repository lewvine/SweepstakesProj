using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //Member variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        private Contestant winner;
        public string Name { get { return name; } }
        public Contestant Winner
        {
            get { return winner; }
            set { winner = value; NotifyConstestants(); }
        }

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Member methods
        public void RegisterContestant(Contestant contestant)
        {
            //This setup does limit the contestant to one sweepstakes at a time.
            contestant.RegistrationNumber = contestants.Count;

            contestant.FirstName = UserInterface.GetUserInputFor("What is your first name?");
            contestant.LastName = UserInterface.GetUserInputFor("What is your last name?");
            contestant.EmailAddress = UserInterface.GetUserInputFor("What is your email?");
            PrintContestantInfo(contestant);
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            int winningNumber = rand.Next(1, contestants.Count - 1);
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(contestant.Key == winningNumber)
                {
                    winner = contestant.Value;
                }
            }
            //Alert all the other contestants a winner has been selected
            NotifyConstestants();
            return winner;
        }

        public void NotifyConstestants()
        {
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(contestant.Value == winner)
                {
                    WinnerMessage(contestant.Value);
                }
                else
                {
                    LoserMessage(contestant.Value);
                }
            }
        }

        //Confirmed these function as written below in a shell program with hard-coded values.
        public void WinnerMessage(Contestant contestant)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Lew Vine", "lew.vine@gmail.com"));
            message.To.Add(new MailboxAddress($"{contestant.FirstName} {contestant.LastName}", $"{contestant.EmailAddress}"));
            message.Subject = $"You've won the {this.name} sweepstakes!";
            message.Body = new TextPart("plain")
            {
                Text = $"Congratulations, {winner.FirstName} for winning the {this.name} Sweepstakes!"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("lew.vine@gmail.com", "MYPASSWORD");

                client.Send(message);
                client.Disconnect(true);
            }
        }

        public void LoserMessage(Contestant contestant)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Lew Vine", "lew.vine@gmail.com"));
            message.To.Add(new MailboxAddress($"{contestant.FirstName} {contestant.LastName}", $"{contestant.EmailAddress}"));
            message.Subject = $"You've lost the {this.name} sweepstakes!";
            message.Body = new TextPart("plain")
            {
                Text = $"Sorry, {contestant.FirstName} won the {this.name} Sweepstakes.  Better luck next time!"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.EMAILSERVER.com", 587, false);

                client.Authenticate("MY E-MAIL", "MYPASSWORD");

                client.Send(message);
                client.Disconnect(true);
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.ShowContestantInfo(contestant);
        }
    }
}
