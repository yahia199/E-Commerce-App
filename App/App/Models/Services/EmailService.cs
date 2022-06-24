using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Services
{
    public class EmailService
    {
        public async Task<bool> SendEmail(string message, string toEmail, string subject)
        {

            SendGridClient client = new SendGridClient("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");
            SendGridMessage msg = new SendGridMessage();

            msg.SetFrom("22029818@student.ltuc.com", "Yahia");
            msg.AddTo(toEmail);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, message);

            await client.SendEmailAsync(msg);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
            return response.IsSuccessStatusCode;

        }

    }
}
