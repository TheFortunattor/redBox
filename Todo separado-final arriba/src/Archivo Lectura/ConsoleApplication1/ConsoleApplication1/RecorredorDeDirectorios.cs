using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RecorredorDeDirectorios
    {
        public static void recorrerDirectorio(DirectoryInfo direccion)
        {

            //Oculta todos los archivos dentro.

            foreach (FileInfo file in direccion.GetFiles())
            {

                File.SetAttributes(file.FullName, FileAttributes.Hidden);

            }

        }

    }
}
