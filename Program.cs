using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Examen_5
{
    public class Program
    {
        static void Main(string[] args, string TextBox_TextChanged)
        {
            string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: TextBox_TextChanged,
                from: new Twilio.Types.PhoneNumber(TextBox_TextChanged),
                to: new Twilio.Types.PhoneNumber("+77785361367")
            );

            Console.WriteLine(message.Sid);
        }
    }
}

