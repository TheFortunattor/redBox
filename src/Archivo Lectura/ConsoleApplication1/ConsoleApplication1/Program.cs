using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static readonly string textFile = @"C:\Users\alumno\AppData\Local\UNDERTALE\file0";
        static void Main(string[] args)
        {
            string salir = "n";
            do{
            Console.Clear();
            Console.WriteLine("Introduzca lo que desea buscar: ");
            String texto;
            texto = Console.ReadLine();

            int i = 0;
            int cont = 0;
            string[] lines = File.ReadAllLines(textFile);
            foreach (string line in lines)
            {
                i++;
                string aux = line;
                aux = aux.ToLower();
                if (aux.IndexOf(texto) != -1)
                {
                    cont++;
                }
                
            }
            Console.WriteLine("Lineas total leidas: "+i+" / Coincidencias: "+cont);

            Console.WriteLine("Desea salir? s/n ");
            salir = Console.ReadLine();

            }while( salir != "s");
        }
    }
}
