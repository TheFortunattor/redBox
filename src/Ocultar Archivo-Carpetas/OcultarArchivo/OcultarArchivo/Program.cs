using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;

namespace OcultarArchivo
{
    class Program
    {


        static void Main(string[] args)
        {
            string direccion = @"C:\Users\" + Environment.UserName + ""; //establece la dirección del archivo
            /*if (!File.Exists(direccion)) //si no existe el archivo lo crea
            {
                File.Create(direccion);
            }
            */
            if (File.Exists(direccion))
            {
                Console.WriteLine("El archivo si existe.");
            }
            if ((File.GetAttributes(direccion) & FileAttributes.Hidden) == FileAttributes.Hidden) //traigo los atributos del archivo y pregunto si está oculto
            {
                File.SetAttributes(direccion, FileAttributes.Archive); //quito lo oculto
                System.Console.WriteLine("El archivo ya no está oculto");
            }
            else
            {
                File.SetAttributes(direccion, FileAttributes.Hidden); //lo oculto
                Console.WriteLine("El archivo está oculto");
            }
            Console.ReadKey(); //espero que se apriete una tecla para salir
        }
        
    }
}
