using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    class Ficheros
    {
        public static void RealizarTest()
        {
            string texto = "";
            //Leemos el fichero
            try
            {
                StreamReader fichero = File.OpenText("C:/Users/D.VIDEOJUEGOS/Desktop/Hola.txt");//abrimos el archivo
                string linea = "";//declaramos la variable string que sera la que vaya recorriendo el fichero

                while (linea != null)
                {
                    linea = fichero.ReadLine();//asignamos a linea, la lectura de la primera linea del fichero
                    texto += linea;//sirve para ir guardando en la variable texto, los textos de las lineas que se va leyendo
                    if (linea != null)
                    {
                        Console.WriteLine(linea);//vamos imprimiendo las lineas
                    }
                }
                fichero.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al abrir el archivo");
            }

            //escribir en un fichero
            try
            {
                StreamWriter fichero = File.CreateText("C:/Users/D.VIDEOJUEGOS/Desktop/Hola.txt");//sobreescribimos o creamos un fichero
                string frase = "Yepa yeeeee";//esta es la frase que vamos a añadir al fichero
                fichero.WriteLine(texto);//escribimos en el fichero el texto que hemos ido guardando antes en la lectura del fichero
                fichero.WriteLine("");//salto de linea
                fichero.WriteLine(frase);//escribimos en el fichero la frase que queremos añadir
                fichero.Close();
                Console.WriteLine("Fichero escrito");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al abrir o crear el archivo");
            }

            Console.ReadLine();
        }
    }
    }

