using System;

namespace InterfacesAndPolymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail...");
        }
    }
}