﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;

namespace Project.Mail
{
    public class MailSettings
    {
        public string? Mail { get; set; }
        public string? DisplayName { get; set; }
        public string? Password { get; set; }
        public string? Host { get; set; }
        public int Port { get; set; }
    }
    public class SendMailService : IEmailSender
    {
        readonly MailSettings? mailsettings;

        public SendMailService(IOptions<MailSettings> setting)
        {
            mailsettings = setting.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.Sender = new MailboxAddress(mailsettings!.DisplayName, mailsettings.Mail);
            message.From.Add(new MailboxAddress(mailsettings.DisplayName,mailsettings.Mail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = subject;

            //body
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = htmlMessage;
            message.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            try
            {
                smtp.Connect(mailsettings.Host, mailsettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                // xác thực
                smtp.Authenticate(mailsettings.Mail, mailsettings.Password);
                // gửi mail
                await smtp.SendAsync(message);
            }
            catch (Exception)
            {
                // lỗi gửi mail => lưu lai nội dung bức mail
                if (!Directory.Exists("mailssave"))
                {
                    Directory.CreateDirectory("mailssave");
                }
                var emailSaveFile = $"mailssave/{Guid.NewGuid()}.eml";
                await message.WriteToAsync(emailSaveFile);
            }
            smtp.Disconnect(true);

        }
    }
}
