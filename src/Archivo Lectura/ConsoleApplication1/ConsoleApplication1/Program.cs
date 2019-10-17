using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        //static readonly string textFile = @"C:\Users\alumno\Desktop\file0.txt";

        static readonly string textFile = @"C:\Users\alumno\UNDERTALE\file01.odt";

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

                       /* using (StreamWriter file = new StreamWriter(@"C:\Users\alumno\UNDERTALE\file01.odt", true))
                        {
                            file.WriteLine("ANDA"); //se agrega información al documento

                            file.Close();
                        }
                       */

            }
            Console.WriteLine("Lineas total leidas: "+i+" / Coincidencias: "+cont);

            

            Console.WriteLine("Desea salir? s/n ");
            salir = Console.ReadLine();

            }while( salir != "s");
        }
    }
}
