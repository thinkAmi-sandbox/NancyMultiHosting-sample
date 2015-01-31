using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = 8765;
            var nancyHost = new Nancy.Hosting.Self.NancyHost(new Uri("http://localhost:" + port));
            Console.WriteLine("Running port: {0}", port);

            nancyHost.Start();

            Console.ReadKey();

            nancyHost.Stop();
        }
    }
}
