using System.Threading.Tasks;

namespace Psychology.Core.Services.Rest
{
    public interface IEmailService
    {
        Task Send(string toEmail, string toName, string template, string subject);
        string CreateAdminTepmlate(string token);
    }
}
