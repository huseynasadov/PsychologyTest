using Microsoft.Extensions.Configuration;
using Psychology.Core.Services.Rest;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace Psychology.Services.Rest
{
    public class EmailService : IEmailService
    {
        private readonly string _company;
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
            _company = _configuration["Company:Name"];
        }
        public async Task Send(string toEmail, string toName, string template, string subject)
        {
            var client = new SendGridClient("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");
            var from = new EmailAddress("huseyn.asadovv@gmail.com", _company);
            var to = new EmailAddress(toEmail, toName);
            var htmlContent = template;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "" , htmlContent);
            await client.SendEmailAsync(msg);
        }

        #region Templates
        public string CreateAdminTepmlate(string link)
        {
            return "<!DOCTYPE html><html lang='en'><head> <meta charset='UTF-8'> <title>"+ _company + "</title> <meta name='viewport' " +
                "content='width = device-width, initial-scale = 1, maximum-scale = 1'></head>" +
                "<body style='margin: 0; padding: 0; " +
                "background - color:#f8f8f8; padding-top: 10px;'> <div leftmargin='0' marginwidth='0' topmargin='0' marginheight='0' " +
                "offset='0' style='height:auto !important;width:100% !important; font-family: Helvetica,Arial,sans-serif !important; " +
                "margin-bottom: 40px;'> <center>" +
                " <table bgcolor='#ffffff' border='0' cellpadding='0' cellspacing='0' style='max-width:600px;" +
                " background-color:#ffffff;border:1px solid #e4e2e2;border-collapse:separate !important; border-radius:4px;border-spacing:0;color:#242128;" +
                " margin:0;padding:40px;' heigth='auto'> " +
                "<tbody><tr> <td align='left' valign='center' style='padding-bottom:40px;border-top:0;height:100% " +
                "!important;width:100% !important;'> <img src='https://coloredstrategies.com/mailing/dore.png'/> </td><td align='right' valign='center'" +
                " style='padding-bottom:40px;border-top:0;height:100% !important;width:100% !important;'> <span style='color: #8f8f8f; font-weight: normal;" +
                " line-height: 2; font-size: 14px;'>" + DateTime.Now.ToString("dd.MM.yyyy") + "</span> </td></tr>" +
                "<tr><td colspan='2'> <table border='0' cellpadding='0' cellspacing='0' width='100%' style='min-width:100%;border-collapse:collapse;'>" +
                " <tbody> <tr> <td style='padding:15px 0px;' valign='top' align='center'>" +
                " <table border='0' cellpadding='0' cellspacing='0'" +
                "style='border-collapse:separate !important;'> <tbody> <tr> <td align='center' valign='middle' style='padding:13px;'> " +
                "<a href='" + link + "' title='DAXIL OL' target='_blank' style='font-size: 14px; line-height: 1.5; font-weight: 700; letter-spacing: 1px; " +
                "padding: 15px 40px; text-align:center; text-decoration:none; color:#FFFFFF; border-radius: 50px; background-color:#145388;'>" +
                "DAXIL OL</a> </td></tr></tbody> </table> </td></tr></tbody> </table> </td></tr></tbody> </table> <table style='margin-top:30px;" +
                " padding-bottom:20px;; margin-bottom: 40px;'> <tbody> <tr> <td align='center' valign='center'> <p style='font-size: 12px;" +
                " text-decoration: none;line-height: 1; color:#909090; margin-top:0px; '> ColoredStrategies Inc, 35 Little Russell St. " +
                "Bloomsburg London,UK </p><p style='font-size: 12px; line-height:1; color:#909090; margin-top:5px;'> <a href='#' style='color: #145388;" +
                " text-decoration:none;'>Privacy Policy</a> | <a href='#' style='color: #145388; text-decoration:none;'>Unscubscribe</a>" +
                " </p></td></tr></tbody> </table> </center> </div></body></html>";
        }
        #endregion

    }
}
