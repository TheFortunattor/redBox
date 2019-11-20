using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Antivirus
{
    class Undertale
    {
        public static void jugar()
        {
            Process.Start(@"C:\Users\" + Environment.UserName + @"\Desktop\redBox\redBoxInterface\redBoxInterface\obj\Debug\redBoxInterface");
        }
    }
}
