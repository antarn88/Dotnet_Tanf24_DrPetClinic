using System;
using System.Net;
using System.Net.Mail;
using DrPetClinic.Web.Settings;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;

namespace DrPetClinic.Web.Services;

public class EmailSender : IEmailSender
{
  private readonly MailSettings mailSettings;

  public EmailSender(IOptions<MailSettings> mailSettings)
  {
    this.mailSettings = mailSettings.Value;
  }

  public async Task SendEmailAsync(string email, string subject, string htmlMessage)
  {
    var client = new SmtpClient(mailSettings.Host, mailSettings.Port)
    {
      Credentials = new NetworkCredential(mailSettings.Mail, mailSettings.Password),
      EnableSsl = true
    };

    await client.SendMailAsync(
      new MailMessage(mailSettings.Mail, email, subject, htmlMessage)
      {
        IsBodyHtml = true
      }
    );
  }

}
