using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class CertCreator
    {
        public static void Create(string Name, string FileName)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Process p1 = Process.Start($"{path}\\makecert.exe", $"-r -pe -n \"CN={Name}\" -eku 1.3.6.1.5.5.7.3.1 -sky exchange -sv {Name}.pvk {Name}.cer");
            p1.WaitForExit();
            Process p2 = Process.Start($"{path}\\pvk2pfx.exe", $"-pvk {Name}.pvk -spc {Name}.cer -pfx {Name}.pfx");
            p2.WaitForExit();
        }
    }
}
