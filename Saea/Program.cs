using Saea.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Saea
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxConnection = 50;
            int bufferSize = (1024 * 1024) * 1; // 1mb
            int port = 6275;
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, port);

            Server server = new Server(maxConnection, bufferSize);
            server.Init();
            server.Start(ip);
        }
    }
}
