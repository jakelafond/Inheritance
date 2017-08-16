using System;
namespace Inheritance
{
    public class TextNotification : Notification
    {
        public string Recipient { get; set; }
        public string SmsProvider { get; set; }

        public TextNotification(string subject, string body, string recipient, string smsProvider):base(subject,body)
        {
            Subject = subject;
            Body = body;
            Recipient = recipient;
            SmsProvider = smsProvider;
        }

        public override void Transport(){
            Console.WriteLine($"Subject:{Subject},Body:{Body},Recipient{Recipient},SMTP Provider:{SmsProvider}");

        }
        
    }
    
}