using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    class Diccionarios
    {

        public static void RealizarTest()
        {
            Dictionary<string, Persona> personas = new Dictionary<string, Persona>();// esto significa que creamos un diccionario que dado un string nos devuelve una persona. Por ejemplo, dado un dni...
            Persona p1 = new Persona("Jorge", "Garcia",23,0,"30489859Z");
            Persona p2 = new Persona("Pepe","Garcia",23,0, "12345678A");
            personas.Add(p1.DNI, p1);
            personas.Add(p2.DNI, p2);

            Console.WriteLine("Hay {0} personas", personas.Count);
            foreach (string dni in personas.Keys)
            {

                Persona p = personas[dni];
                Console.WriteLine(p);
                ;
            }

            Console.ReadLine();
        }
    }
    }

