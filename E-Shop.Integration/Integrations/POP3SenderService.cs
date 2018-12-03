using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Integration.Interfaces;

namespace E_Shop.Integration.Integrations
{
    public class POP3SenderService : IEmailSenderService
    {
        public void SendMessage(string message)
        {
            Debug.Print(message);
            
        }
    }
}
