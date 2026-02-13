using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSolid.SOLID
{
    internal interface IMailService
    {
        void SendEmail(string recipient, string subject, string body);
    }

    internal class MailService : IMailService
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            Console.WriteLine($"Mail is sending to {recipient}, with subject {subject}, with body {body}");
        }
    }

    internal class DependencyInversionPrinciple
    {
        private readonly IMailService mailService;

        public DependencyInversionPrinciple(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public void SendMessage(string message)
        {
            this.mailService.SendEmail("abc@gmail.com", "Hello", "Hi");
        }
    }
}
