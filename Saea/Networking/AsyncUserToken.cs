using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Saea.Networking
{
    class AsyncUserToken
    {
        public AsyncUserToken() : this(null)
        {

        }

        public AsyncUserToken(Socket socket)
        {
            Socket = socket;
        }

        public Socket Socket { get; set; }
    }
}
