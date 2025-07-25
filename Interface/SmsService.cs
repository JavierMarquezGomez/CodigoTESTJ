using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SmsService :  IMessaginServices
    {
        public void sendMessage(string recipient, string message)
        {
            Console.WriteLine($"Enviando SMS mensaje de {recipient}: {message} ");
        }

    }
}
