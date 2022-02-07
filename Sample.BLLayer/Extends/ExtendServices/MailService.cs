using Sample.BLLayer.Extends.ExtendModels;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.BLLayer.Extends.ExtendServices
{
    public class MailService : IMailService
    {
        private ILogger<MailService> _logger;
        private IConfiguration _configuration { get; }
        public MailService(ILogger<MailService> logger,
                           IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        public async Task SendEmailAsync(
        string subject,
        string body,
        IEnumerable<MailAdress> sendTo = null,
        MailConfiguration configuration = null,
        IEnumerable<MailAdress> Cc = null,
        IEnumerable<MailAdress> Bcc = null,
        BodyBuilder bodyBuilder = null)
        {
            if (configuration == null)
            {
                IConfigurationSection mailSection = _configuration.GetSection("MailSender");
                configuration = new MailConfiguration
                {
                    Host = mailSection.GetValue<string>("Host"),
                    Port = mailSection.GetValue<int>("Port"),
                    UserName = mailSection.GetValue<string>("UserName"),
                    UserEmail = mailSection.GetValue<string>("UserEmail"),
                    Password = mailSection.GetValue<string>("Password"),
                    SendToUserEmail = mailSection.GetValue<string>("SendToUserEmail"),
                    SendToUserName = mailSection.GetValue<string>("SendToUserName"),
                };
            }
            if (sendTo == null && !string.IsNullOrEmpty(configuration.SendToUserEmail))
            {
                var sendToUser = new MailAdress(configuration.SendToUserName, configuration.SendToUserEmail);
                sendTo = new List<MailAdress>() { sendToUser };
            }
            using var client = new SmtpClient();

            Task connectTask = client.ConnectAsync(configuration.Host, configuration.Port);

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(configuration.UserName, configuration.UserEmail));
            message.To.AddRange(sendTo.Select(to => new MailboxAddress(to.Name, to.Address)).ToList());

            if (Cc != null && Cc.Any())
                message.Cc.AddRange(Cc.Select(cc => new MailboxAddress(cc.Name, cc.Address)).ToList());

            if (Bcc != null && Bcc.Any())
                message.Bcc.AddRange(Bcc.Select(bcc => new MailboxAddress(bcc.Name, bcc.Address)).ToList());

            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            try
            {
                await connectTask;

                client.Authenticate(configuration.UserEmail, configuration.Password);
                if (null != bodyBuilder)
                {
                    message.Body = bodyBuilder.ToMessageBody();
                }
                client.Send(message);


                var logMessage = JsonConvert.SerializeObject(new
                {
                    message?.From,
                    sendTo,
                    Cc,
                    Bcc,
                    subject,
                    body
                });

                _logger.LogInformation(logMessage);

                client.Disconnect(true);

            }
            catch (Exception ex)
            {
                throw new MailException(ex);
            }
        }
    }
}
