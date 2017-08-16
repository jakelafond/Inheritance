using System;

namespace Inheritance
{
    public abstract class Notification
    {
        public DateTime createdAt { get; set; } = DateTime.Now;
        public string Subject { get; set; }
        public string Body { get; set; }

        public Notification(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }

        public abstract void Transport();

    }

}