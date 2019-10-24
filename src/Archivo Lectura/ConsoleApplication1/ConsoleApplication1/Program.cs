using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        //static readonly string textFile = @"C:\Users\alumno\Desktop\file0.txt";

        // static readonly string textFile = @"C:\Users\alumno\UNDERTALE\file01.odt";
            

        static void Main(string[] args)
        {

            // ArrayList aux = new ArrayList();

            //string textFile = @"C:\Users\alumno\UNDERTALE\file01.odt";

            string textFile = @"C:\Users\" + Environment.UserName + @"\UNDERTALE\file01.odt";

            // string textFile = @"C:\Users\" + Environment.UserName + @"\UNDERTALE";

            //DirectoryInfo Dif = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\UNDERTALE");

            StreamReader sr = new StreamReader(textFile, Encoding.Unicode);

            string salir = "n";

            string aux = "";

            bool primeraVez = true;

            do
            {

                Console.Clear();

                Console.WriteLine("Ejecutando...");

               // salir = Console.ReadLine();

                string texto = "Soy una almeja";

                //int cont = 0;

                string tex = File.ReadAllText(textFile); //Lee todo lo que tiene el archivo y lo guarda en la variable.

                // foreach (string line in lines)
                //{

                //cont++;

                //aux.Add(line);

                if (primeraVez==true)
                {

                    aux = tex; //aux guarda los valores originales.

                    File.WriteAllText(textFile, texto);

                   // tex = tex.Replace(tex, texto); //se reemplaza lo original por la palabra clave.

                    primeraVez = false;

                }

                if (salir == "d")
                {

                    File.WriteAllText(textFile, aux); //se reemplaza la palabra clave por el texto original

                }

                if (salir == "o")
                {

                   // Dif.CreateSubdirectory();

                    //File.SetAttributes(textFile, FileAttributes.Hidden);

                }

                //File.WriteAllText(textFile, tex); //se escribe

                // aux = aux.ToLower();
                //string archivoTexto = File.ReadAllText(textFile);


                //File.WriteAllText(@"C:\Users\alumno\UNDERTALE\file01.odt", archivoTexto);






                /* if (salir == "d")
                 {

                     archivoTexto = archivoTexto.Replace(texto, aux.);

                 }*/
                //  }

                // int i = 0;
                //int cont = 0;
                /* string[] lines = File.ReadAllLines(textFile);
                 foreach (string line in lines)
                 {
                     cont++;
                     string aux = line;
                     aux = aux.ToLower();
                     if (aux.IndexOf(texto) != -1)
                     {
                         cont++;
                     }

                         



                         /* using (StreamWriter file = new StreamWriter(@"C:\Users\alumno\UNDERTALE\file01.txt", true))
                              {
                                  file.WriteLine("ANDA"); //se agrega información al documento

                                  file.Close();
                              }
                              */
                /* using (StreamWriter file = new StreamWriter(@"C:\Users\alumno\UNDERTALE\file01.odt", true))
                 {
                     file.WriteLine("ANDA"); //se agrega información al documento

                     file.Close();
                 }


            }
            Console.WriteLine("Lineas total leidas: "+i+" / Coincidencias: "+cont);

         */

                Console.WriteLine("Desea salir? s/n ");
                salir = Console.ReadLine();

            }while(salir != "s");
        }
    }
}
