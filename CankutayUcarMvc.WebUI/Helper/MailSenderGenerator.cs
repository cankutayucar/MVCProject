using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI.Helper
{
    public static class MailSenderGenerator
    {
        public static void SendEmail(string body, string title, string to)
        {
            MailMessage message = new MailMessage("", to);
            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new NetworkCredential("cankutayucar@gmail.com", "12345qwe");
            smtp.Host = "smtp@gmail.com";
            smtp.Port = 465;
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
