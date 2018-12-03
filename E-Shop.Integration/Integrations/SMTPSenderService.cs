using E_Shop.Integration.Interfaces;
using System.Diagnostics;

namespace E_Shop.Integration.Integrations
{
    public class SMTPSenderService : IEmailSenderService
    {
        public void SendMessage(string message)
        {
            Debug.Print(message);
        }
    }
}
