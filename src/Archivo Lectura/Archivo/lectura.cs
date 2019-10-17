using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectura
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            string line, buscar;
            Boolean continuar = false;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\alumno\AppData\Local\UNDERTALE\file0");

            System.Console.WriteLine("Ingrese numero o palabra:");
            buscar = Console.ReadLine();

            line = file.ReadLine();
            do
            { 
                if (buscar == line)
                {
                    continuar = true;
                }

            } while ((line = file.ReadLine()) != null && continuar==false);

            if (continuar==false)
            {
                System.Console.WriteLine("No se encontro resultados.");
            }
            else
            {
                System.Console.WriteLine("Palabra/numero: "+buscar);
            }

            file.Close();

            /*
            while ((line = file.ReadLine()) != null)
            {
                if (buscar==line)
                {
                    continuar = true;
                }

                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
            */

            /* string Text= System.IO.File.ReadAllText(@"C:\Users\alumno\AppData\Local\UNDERTALE\file0");
             System.Console.WriteLine("Contenido del archivo = {0}", Text);
             System.Console.WriteLine("Presione cualquier tecla para salir.");
             System.Console.ReadKey();
             */
        }
    }    
}