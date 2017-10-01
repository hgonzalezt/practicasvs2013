using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicios_directorios
{
    public partial class Form1 : Form
    {
        String ls_dir_archivo, ls_archivo_leido_ok, ls_archivo_leido_error, ls_fichero_leido;
        public string[] linea_basetb;
        public int contador_linea = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void leer_basetb()
        {
            linea_basetb = new string[2000];
            
            try
            {
                using (StreamReader sr = new StreamReader("E:\\Recursos\\soporte\\SentSQL.txt", false))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        linea_basetb[contador_linea] = (linea);
                        contador_linea++;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }
            
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            
            //falta leer el directorio basetb con el directorio de ficheros
            txt_salida.Text = "";
            string contenido = String.Empty;
            string[] listaFicheros;
            string[] listaFicheros_ok;
            string[] listaFicheros_fallo;
            string ls_nombre_leido;
            string miDirectorio = @" E:\Recursos ";
            int contador_ok = 0, contador_fallo=0;
            int j_ok = 0, j_error = 0;

            //DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(miDirectorio);
            FileInfo[] infoFicheros = dir.GetFiles();

            listaFicheros_ok = new string[2000];
            listaFicheros_fallo = new string[2000];

            //método "GetFiles" que nos permite obtener la lista de ficheros que contiene un directorio
            listaFicheros = Directory.GetFiles(miDirectorio);

            for (int i = 0; i < listaFicheros.Length; i++)
            {
                ls_dir_archivo = listaFicheros[i];
                txt_salida.Text = txt_salida.Text + ls_dir_archivo + "\r\n";
            }

            foreach (FileInfo infoUnFich in infoFicheros)
            {
               ls_nombre_leido= infoUnFich.Name ;
               if (ls_nombre_leido.Contains("OK") == true)
               {
                   listaFicheros_ok[j_ok] = ls_nombre_leido;
                   j_ok++;
               }
               else
               {
                   if (ls_nombre_leido.Contains("ERROR") == true)
                   {
                       listaFicheros_fallo[j_error] = ls_nombre_leido;
                       j_error++;
                   }
               }       
            }

            // Call Array.Sort method.
            //Array.Sort(listaFicheros_ok);
           // Array.Sort(listaFicheros_fallo);
            string temp;
            for (int i = 1; i < j_error; i++)
            {
                for (int j = 0; j <= i; j++)
                    if (listaFicheros_fallo[i].CompareTo(listaFicheros_fallo[j]) < 0)
                    {
                        temp = listaFicheros_fallo[i];
                        listaFicheros_fallo[i] = listaFicheros_fallo[j];
                        listaFicheros_fallo[j] = temp;
                    }
            }

            //leer el basetb y llevarlo a un vector, despues contains la sentencia
            leer_basetb();
           
           
            for (int i = 0; i < listaFicheros.Length; i++)
            {
                ls_archivo_leido_ok = listaFicheros[i];

                for (int k = 0; k < j_ok; k++)
                 {
                    ls_fichero_leido = listaFicheros_ok[k];
                    ls_archivo_leido_error = listaFicheros_fallo[k];

                    if (ls_fichero_leido!=null)
                    {
                    if (ls_archivo_leido_ok.Contains(ls_fichero_leido) == true)
                        {
                            if (File.Exists(ls_archivo_leido_ok))
                            {
                                try
                                {
                                    using (StreamReader sr = new StreamReader(ls_archivo_leido_ok, false))
                                    {
                                        string line, ls_linea_basetb;
                                       
                                        
                                        while ((line = sr.ReadLine()) != null)
                                        {
                                            for (int l = 0; l < contador_linea; l++)
                                            {
                                               ls_linea_basetb = linea_basetb[l];

                                               if (line.Contains(ls_linea_basetb) == true)
                                                {
                                                    if (line.Contains("OK") == true)
                                                    {
                                                        txt_detalles.Text = txt_detalles.Text + line + "\r\n";
                                                        contador_ok++;
                                                    }
                                                    else
                                                        //revisar
                                                    {
                                                        contador_fallo++;
                                                    }
                                                }
                                                
                                            }                            
                                        }
                                        dtgrid_servidor.Rows.Add();
                                        int cantidadfilas=dtgrid_servidor.Rows.Count-1;
                                        dtgrid_servidor[0, cantidadfilas].Value = ls_fichero_leido;
                                        dtgrid_servidor[1, cantidadfilas].Value = ls_archivo_leido_error;
                                        dtgrid_servidor[2, cantidadfilas].Value = contador_ok;
                                        if ( (contador_fallo > 1)  || (contador_linea - contador_ok)>0 ) 
                                        {
                                            dtgrid_servidor[3, cantidadfilas].Value=("FALLO");
                                        }
                                        
                                        contador_ok = 0;
                                        contador_fallo = 0;
                                    }
                                }
                                catch (Exception)
                                {
                                     txt_detalles.Text = txt_detalles.Text + "El archivo no se puede leer";
                                }
                            }
                            else
                            {
                                txt_detalles.Text = txt_detalles.Text + "El archivo no existe";
                            }
                        }
                        else
                        {
                            txt_detalles.Text = txt_detalles.Text + "El archivo no tiene uno similar";
                        }
                    }
                }
            }               
        }

        // la clase DirectoryInfo permite obtener información sobre fechas de creación, modificación y acceso, y,
        //de forma análoga, FileInfo nos permite conseguir información similar sobre un fichero.
        private void btn_detalle_dir_Click(object sender, EventArgs e)
        {
            string miDirectorio = @" e:\Documentos 2015 ";
            DirectoryInfo dir = new DirectoryInfo(miDirectorio);
            FileInfo[] infoFicheros = dir.GetFiles();
            foreach (FileInfo infoUnFich in infoFicheros)
            {
                   //Console.WriteLine("{0}, de tamaño {1}, creado {2}",
                   // infoUnFich.Name,
                   // infoUnFich.Length,
                   // infoUnFich.CreationTime);
                   txt_detalles.Text = txt_detalles.Text + infoUnFich.Name + "  " + infoUnFich.Length + "   " + infoUnFich.CreationTime + "\r\n";
            }
        }
    }
}
