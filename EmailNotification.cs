using System;
namespace Inheritance
{
    public class EmailNotification : Notification
    {
        public string Recipient { get; set; }
        public string SmtpProvider { get; set; }

        public EmailNotification(string subject, string body, string recipient, string smtpProvider):base(subject,body)
        {
            Subject = subject;
            Body = body;
            Recipient = recipient;
            SmtpProvider = smtpProvider;
        }

        public override void Transport(){
            try
            {
            Console.WriteLine($"Subject:{Subject},Body:{Body},Recipient{Recipient},SMTP Provider:{SmtpProvider}");  
            }
            catch (NoTransportException)
            {
                
                throw;
            }

        }
        
    }
    
}