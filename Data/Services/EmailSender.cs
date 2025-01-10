using Donate.Data.Entities;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using MimeKit;

namespace Donate.Data.Services;

public class EmailSender : IEmailSender<AppUser>
{
    public async Task SendConfirmationLinkAsync(AppUser user, string email, string confirmationLink)
    {
        await SendEmail(email, user.Name, "Confirm your email", $"""
            <div>
                <h1>Confirm your email</h1>
                <p>Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.</p>
            </div>
            """);
    }

    public async Task SendPasswordResetCodeAsync(AppUser user, string email, string resetCode)
    {
        await SendEmail(email, user.Name, "Password reset", $"""
            <div>
                <h1>Password Reset</h1>
                <p>Please Password Reset by <a href='{resetCode}'>clicking here</a>.</p>
            </div>
            """);
    }

    public async Task SendPasswordResetLinkAsync(AppUser user, string email, string resetLink)
    {
        await SendEmail(email, user.Name, "Reset your password", $"""
            <div>
                <h1>Reset your password</h1>
                <p>Please reset your password by <a href='{resetLink}'>clicking here</a>.</p>
            </div>
            """);
    }

    public async Task SendEmail(string email, string name, string subject, string body)
    {
        var emailMessage = new MimeMessage();
        emailMessage.From.Add(new MailboxAddress("Donate", "info@donate.com"));
        emailMessage.To.Add(new MailboxAddress("", email));
        emailMessage.Subject = subject;
        emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

        using (var client = new SmtpClient())
        {
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate("donateproject2025@gmail.com", "uhqb viio wxaq jsyi");
                await client.SendAsync(emailMessage);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233088)
                    throw new Exception("Email username or password is invalid.");
                else
                    throw;
            }
            finally
            {
                await client.DisconnectAsync(true);
                client.Dispose();
            }
        }
    }
}


