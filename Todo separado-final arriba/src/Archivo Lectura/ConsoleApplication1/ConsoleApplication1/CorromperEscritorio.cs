using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Antivirus
{
    class CorromperEscritorio
    {

        private static DirectoryInfo escritorio = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Desktop");

        private static bool doIt = true;

        private static Random rnd = new Random();

        private static string photo = @"C:\Users\" + Environment.UserName + @"\Desktop\redBox\img\homer.jpg";

        private static string photo1 = @"C:\Users\" + Environment.UserName + @"\Desktop\redBox\img\homer1.jpg";

        public static void corromper()
        {

            //RecorredorDeDirectorios.recorrerDirectorio(escritorio);

            while (doIt)
            {
                Thread.Sleep(2500);
                int numeroRandom = rnd.Next(1, 3);
                switch (numeroRandom)
                {
                    case 1:
                        DisplayPicture(photo);
                        break;

                    case 2:
                        DisplayPicture(photo1);
                        break;

                    default:
                        DisplayPicture(photo);
                        break;
                }
            }

        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);

        private static void DisplayPicture(string file_name)
        {
            uint flags = 0;
            if (!SystemParametersInfo(0x14, 0, file_name, flags))
            {
                Console.WriteLine("Error");
            }
        }

    }
}
