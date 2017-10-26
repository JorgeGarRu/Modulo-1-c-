using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class Listas
    {

        public static void RealizarTest()
        {
            #region Ejemplo 
            Persona[] personas = new Persona[4];//asi se crea un array de personas

            Persona p1 = new Persona("jorge");

            List<Persona> personas2 = new List<Persona>();//asi se crea una lista de personas

            Console.Write(personas.Length); //asi se devuelve la longitud del array
            Console.Write(personas2.Count);//asi se devuelve la longitud de la lista


            personas2.Add(p1);//asi se añade una persona a la lista
            personas2.Remove(p1);//asi se borra una persona de la lista

            #endregion

            #region Ejercicio1 RepasoLista
            //RepasoListas repaso = new RepasoListas();//solo se puede usar el metodo ejecutar, haciendo una instancia de la clase RepasoLista, a no ser que sea estatico
            //repaso.EjecutarMetodoNoEstatico();

            //Console.ReadLine();

            //RepasoListas.EjecutarMetodoEstatico();//asi seria si el metodo ejecutar fuese estatico

            //Console.ReadLine();

            #endregion
        }
    }
}