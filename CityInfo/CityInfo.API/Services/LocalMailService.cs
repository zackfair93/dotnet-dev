﻿namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        public string _mailTo = "admin@mycompany.com";
        public string _mailFrom = "noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            // Send mail - output to console window
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}.");

            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
