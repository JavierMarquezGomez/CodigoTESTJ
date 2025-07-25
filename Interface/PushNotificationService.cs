using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class PushNotificationService : IMessaginServices
    {
        public void sendMessage(string recipient, string message)
        {
            Console.WriteLine($"Enviando Push mensaje de {recipient}: {message} ");
        }

    }
}
