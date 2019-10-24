using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcultarIconos
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Desktop");

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

            Console.ReadKey(); //espero que se apriete una tecla para salir
        }
    }
}
