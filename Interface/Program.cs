using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessaginServices email = new EmailService();
            IMessaginServices sms = new SmsService();
            IMessaginServices push = new PushNotificationService();

            Sendalert(email,"jav", "hola email");
            Sendalert(sms, "jav", "hola sms");
            Sendalert(push, "jav", "hola Push");

            Console.WriteLine("Termina proceso");
            Console.Read();


        }

        static void Sendalert( IMessaginServices messaginServices , string recipient, string message)
        {
            messaginServices.sendMessage(recipient,message);
        }
    }
}
