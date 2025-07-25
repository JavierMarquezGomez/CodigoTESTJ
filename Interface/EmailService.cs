using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class EmailService : IMessaginServices
    {
        public void sendMessage(string recipient, string message)
        {
            Console.WriteLine($"Enviando EMAIL mensaje de {recipient}: {message} ");
        }
    }
}
