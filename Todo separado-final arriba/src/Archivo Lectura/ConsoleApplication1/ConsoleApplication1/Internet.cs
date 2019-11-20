using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Internet
    {

        public static void abrirPagina()
        {

            for (int i = 0; i < 10; i++)
            {

                Thread.Sleep(2500);
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo("https://cat-bounce.com/");
                p.StartInfo = psi;
                p.Start();

            }
        }
    }
}
