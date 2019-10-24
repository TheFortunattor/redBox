using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;


namespace Ocultamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string photo = @"D:\Cruz 6°1°\redBox\src\Ocultar iconos-(archivo o carpetas)-\Imagenes\homer.jpg";
            string photo1 = @"D:\Cruz 6°1°\redBox\src\Ocultar iconos-(archivo o carpetas)-\Imagenes\homer1.jpg";
            string direccion = @"C:\Users\" + Environment.UserName + "";

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Desktop");

            if ((File.GetAttributes(direccion) & FileAttributes.Hidden) == FileAttributes.Hidden) //traigo los atributos del archivo y pregunto si está oculto
            {
                File.SetAttributes(direccion, FileAttributes.Archive); //quito lo oculto
                System.Console.WriteLine("La carpeta ya no está oculta");
            }
            else
            {
                File.SetAttributes(direccion, FileAttributes.Hidden); //lo oculto
                Console.WriteLine("La carpeta está oculta");
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                if ((File.GetAttributes(file.FullName) & FileAttributes.Hidden) == FileAttributes.Hidden) //traigo los atributos del archivo y pregunto si está oculto
                {
                    File.SetAttributes(file.FullName, FileAttributes.Archive); //quito lo oculto
                    System.Console.WriteLine("El archivo " + file.FullName + " ya no está oculto");
                }
                else
                {
                    File.SetAttributes(file.FullName, FileAttributes.Hidden); //lo oculto
                    Console.WriteLine("El archivo " + file.FullName + " está oculto");
                }

            }

            for (int i = 0; i < 5; i++)
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

                }
            }

            Console.ReadKey(); //espero que se apriete una tecla para salir
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
