using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Link de refencia en el cual encontré el codigo.
        /*https://www.codeproject.com/Questions/1252479/How-do-I-change-the-desktop-background-using-Cshar*/

        static void Main(string[] args)
        {
            string photo = @"D:\Cruz 6°1°\redBox\src\Cambiar fondo de escritorio\Imagenes\homer.jpg";
            DisplayPicture(photo);
        }
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);

            private const uint SPI_SETDESKWALLPAPER = 0x14;
            private const uint SPIF_UPDATEINIFILE = 0x1;
            private const uint SPIF_SENDWININICHANGE = 0x2;

            private static void DisplayPicture(string file_name)
            {
                uint flags = 0;
                if (!SystemParametersInfo(SPI_SETDESKWALLPAPER,
                        0, file_name, flags))
                {
                    Console.WriteLine("Error");
                }
            }
   
    }
}

