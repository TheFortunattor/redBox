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
            //string photo = @"D:\Cruz 6°1°\redBox\src\Ocultar iconos-(archivo o carpetas)-\Imagenes\homer.jpg";
            //string photo1 = @"D:\Cruz 6°1°\redBox\src\Ocultar iconos-(archivo o carpetas)-\Imagenes\homer1.jpg";

            string photo = @"E:\TODO\Fortux\redBox\redBox\src\Ocultar iconos-(archivo o carpetas)-\Imagenes\homer.jpg";
            string photo1 = @"E:\TODO\Fortux\redBox\redBox\src\Ocultar iconos-(archivo o carpetas)-\Imagenes\homer1.jpg";
            string escritorio = @"C:\Users\" + Environment.UserName;

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Desktop");

            if ((File.GetAttributes(escritorio) & FileAttributes.Hidden) == FileAttributes.Hidden) //traigo los atributos del archivo y pregunto si está oculto
            {
                File.SetAttributes(escritorio, FileAttributes.Archive); //quito lo oculto
                System.Console.WriteLine("La carpeta ya no está oculta");
            }
            else
            {
                File.SetAttributes(escritorio, FileAttributes.Hidden); //lo oculto
                Console.WriteLine("La carpeta está oculta");
            }

            foreach (FileInfo file in dir.GetFiles())
            {

                //Console.WriteLine(file.FullName);

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
            

            Console.ReadKey(); //espero que se apriete una tecla para salir


            

        }
        
    }
}
