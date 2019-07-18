using NDesk.Options;
using Newtonsoft.Json;
using System;
using System.Net;

namespace RabbitMqMessageStatusCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:15672/api",
                   userName = "guest",
                   password = "guest",
                   queueName = null,
                   vhost = "/";

            var p = new OptionSet() {
                    { "u|baseUrl=",  v => baseUrl = v },
                    { "U|user=",     v => userName = v },
                    { "p|password=", v => password = v },
                    { "q|queue=",    v => queueName = v },
                    { "v|vhost=",    v => vhost = v }
                    };
            p.Parse(args);

            var client = new WebClient();
            if (userName != null)
                client.Credentials = new NetworkCredential(userName, password);

            var url = baseUrl + "/queues/" + Uri.EscapeDataString(vhost) + "/" + Uri.EscapeDataString(queueName);
            var data = client.DownloadString(url);
            var queueInfo = JsonConvert.DeserializeObject<QueueInfo>(data);

            // Here is where we report the message count to our monitoring system.
            // Replace the console output/wait with your code.
            Console.WriteLine("Queue: " + queueInfo.Name);
            Console.WriteLine("Queue Depth: " + queueInfo.MessagesReady.ToString());
            Console.WriteLine("Queue Ifo: " + JsonConvert.SerializeObject(data));

            Console.Write("\r\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
