using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class Algoritmos
    {
        //Algoritmo de busqueda --> quiero buscar un individuo que tenga un atributo en concreto
        public static Persona GetPersonaPorDNI(string dni) //Algoritmo para buscar a la persona que tenga el dni introducido.
        {
            Persona res = null;

            List<Persona> personas = new List<Persona>();
            foreach (Persona p in personas)
            {
                if (p.DNI == dni)
                {
                    res = p;
                    break;
                }
            }
            return res;
        }


        //Algoritmo de Existe --> quiero saber si existe algun individuio que tenga un atributo en concreto
        public static bool ExistePersonaPorDNI(string dni)//algoritmo para saber si existe una persona con dicho dni introducido
        {
            bool res = false;
            List<Persona> personas = new List<Persona>();
            foreach (Persona p in personas)
            {
                if (p.DNI == dni)
                {
                    res = true;
                    break;
                }
            }

            return res;

        }

        //Algoritmo de Mejor/Peor --> 
        public static Persona PersonaMasMayor()//Algoritmo para saber que persona es la que mas edad tiene.
        {
            Persona res = null;
            List<Persona> personas = new List<Persona>();

            foreach (Persona p in personas)
            {
                if (res == null) //si no tengo a nadie...
                {
                    res = p; //nos quedamos con la primera persona para empezar a comparar.
                }
                else if (p.Edad > res.Edad) //si la edad de la siguiente persona es mayor que la edad de la persona que tenemos guardada..
                {
                    res = p;//nos quedamos con la persona nueva.
                }


                //Otra forma de poner el if 
                //if (res == null || res.Edad < p.Edad) //si la persona que tenemos es Null o la edad de la persona que tenemos es menor que la edad de la proxima persona...
                //{
                //    res = p;//nos quedamos con la nueva persona.
                //}
            }

            return res;


        }




        //Algoritmo de Conteo --> quiero saber el numero de individuos que cumplan una condicion

        public static int NumeroPersonasMayorDe(int edad) //algoritmo para saber el numero de personas que sean mayores que la edad introducida
        {
            int res = 0;
            List<Persona> personas = new List<Persona>();

            foreach (Persona p in personas)
            {
                if (p.Edad >= edad)
                {
                    res++;
                }
            }
            return res;
        }


        //Algoritmo de Para Todos --> 


        public static bool SoloHombre() //algoritmo para saber si todas las personas son hombres
        {
            bool res = true;
            List<Persona> personas = new List<Persona>();

            foreach (Persona p in personas)
            {
                if (p.Sexo != Sexo.Hombre)
                {
                    res = false;
                    break;
                }


            }
            return res;
        }



    }
}

