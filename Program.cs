using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var watEmail = new EmailNotification("WAT?","OKAY!","You@email.com","AOL");
            watEmail.Transport();

            var lolText = new TextNotification("Guess what?", "LOLOLOLOLOLOL", "NotYou@email.com", "Outlook");
            lolText.Transport();
        }
    }
}
