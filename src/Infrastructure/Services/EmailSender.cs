using eshop.ApplicationCore.Interfaces;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
