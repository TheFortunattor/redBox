using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static readonly string textFile = @"C:\Users\alumno\AppData\Local\UNDERTALE";
        static void Main(string[] args)
        {
           // string direccion = @"C:\Users\alumno\AppData\Local\UNDERTALE";
            string salir = "n";
            do
            {
                Console.Clear();
             //1ER CASO
                String texto = "232";

                int i = 0;

                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {
                    i++;
                    string aux = line;
                    aux = aux.ToLower();
                    if (aux.IndexOf(texto) != -1)
                    {
                        if ((File.GetAttributes(textFile) & FileAttributes.Hidden) == FileAttributes.Hidden) //traigo los atributos del archivo y pregunto si está oculto
                        {
                            File.SetAttributes(textFile, FileAttributes.Archive); //quito lo oculto
                            System.Console.WriteLine("El archivo ya no está oculto");
                            System.Console.WriteLine("Fila: "+i+" Valor: "+line);
                        }
                        else
                        {
                            File.SetAttributes(textFile, FileAttributes.Hidden); //lo oculto
                            Console.WriteLine("El archivo está oculto");
                            System.Console.WriteLine("Fila: " + i + " Valor: " + line);

                        }
                    }


                    /*
                    //2DO CASO

                    i++;
                    System.Console.WriteLine(i);
                    if (i==548)
                    {
                        if ((File.GetAttributes(textFile) & FileAttributes.Hidden) == FileAttributes.Hidden) //traigo los atributos del archivo y pregunto si está oculto
                        {
                            File.SetAttributes(textFile, FileAttributes.Archive); //quito lo oculto
                            System.Console.WriteLine("El archivo ya no está oculto");
                        }
                        else
                        {
                            File.SetAttributes(textFile, FileAttributes.Hidden); //lo oculto
                            Console.WriteLine("El archivo está oculto");
                        }
                    }
                    */
                }
                
                Console.WriteLine("Desea salir? s/n ");
                salir = Console.ReadLine();

            } while (salir != "s");
        }
    }
}
