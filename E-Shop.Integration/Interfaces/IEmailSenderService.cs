using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Integration.Interfaces
{
    public interface IEmailSenderService
    {
        void SendMessage(string message);
    }
}
