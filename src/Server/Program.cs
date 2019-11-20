using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static int Main(string[] args)
        {
            //CertCreator.Create("lalo", "lal");
            Server.RunServer("lalo.pfx");
            return 0;
        }
    }
}
