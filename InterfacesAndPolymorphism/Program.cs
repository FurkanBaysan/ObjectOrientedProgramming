using System;

namespace InterfacesAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            Video video = new Video();
            encoder.Encode(video);
        }
    }
}
