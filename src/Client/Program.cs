using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static int Main(string[] args)
        {
            Client.RunClient("127.0.0.1", "lalo", 23);
            Console.Read();
            return 0;
        }
    }
}
