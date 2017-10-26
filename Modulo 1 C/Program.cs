using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ejemplo llamada al constructor String

            //string eventoEstudio = "ESO,2,IES Vicente Aleizandre";

            //Evento e1 = new Evento(eventoEstudio);

            //Console.WriteLine("------------Estudios----------- \n" + e1);


            //string eventoExperiencia = "Becario,1,Everis";

            //Evento exp1 = new Evento(eventoExperiencia);

            //Console.WriteLine("\n-----------Experiencia------------\n" + exp1);





            //string candidato = "Pepe,Botella,23,0,34343324Z,Programador junior";

            //Candidato c1 = new Candidato(candidato);

            //Evento estudio1 = new Evento("Teleco, 2, Los Viveros");
            //Evento estudio2 = new Evento("Informatica,3,Altair");
            //Evento[] estudios = new Evento[] { estudio1, estudio2 };

            //Evento experiencia1 = new Evento("Soldador", 3, "Fabrica Cocacola");
            //Evento[] experiencias = new Evento[] { experiencia1 };

            ////Segunda forma de crear los eventos:
            //Evento[] EEstudios = new Evento[2]; //creo un array de EEstudios, que solo va a tener 2 estudios
            //EEstudios[0] = new Evento("Teleco,2,Los Viveros");//aqui le doy los datos del estudio creado arriba (nombre, años, lugar)
            //EEstudios[1] = new Evento("Informatica,4,Altair");
            //Evento[] EExperiencia = new Evento[1];
            //EExperiencia[0] = new Evento("Soldador", 3, "Fabrica Cocacola");
            //CV cv = new CV(EEstudios, EExperiencia, c1);


            //c1.CV = cv;
            //Console.WriteLine("\n-------------Candidato---------------\n" + c1);



            #endregion

            #region Ejemplo del metodo equals

            //Persona p1 = new Persona("jorge", "Garcia", 23, 0, "12345678");
            //Persona p2 = new Persona("Jorge", "Garcia", 23, 0, "12345678");
            //Persona p3 = new Persona("Pepe", "Garcia", 23, 0, "12344678");

            //Console.WriteLine("P1 vs P2");
            //Console.WriteLine(p1.Equals(p2));

            //Console.WriteLine("p1 vs P3");
            //Console.WriteLine(p1.Equals(p3));

            //Console.WriteLine("p2 vs p3");
            //Console.WriteLine(p2.Equals(p3));

            #endregion

            #region Ejemplo 1 Metodo Virtual de clase Animal y Perro

            //Animal animal1 = new Animal();
            //Perro perro1 = new Perro();

            //animal1.ReproducirSonido();
            //perro1.ReproducirSonido();

            #endregion

            #region Ejemplo 2 Metodo Virtual de clase Animal y Perro

            //Animal animal1 = new Animal();
            //Perro perro1 = new Perro();

            //string frase = animal1.ReproducirSonido();
            //Console.WriteLine(frase);
            //string frase1 = perro1.ReproducirSonido();
            //Console.WriteLine(frase1);

            #endregion

            #region Ejemplo Listas y diccionarios

            //List<Persona> personas = new List<Persona>();

            //Persona p1 = new Persona("jorge", "Garcia", 25, 0, "12345678A");
            //Persona p2 = new Persona("Jorge", "Garcia", 23, 0, "12345678B");
            //Persona p3 = new Persona("Pepe", "Garcia", 28, 0, "12345678C");



            //personas.Add(p1);
            //personas.Add(p2);
            //personas.Add(p3);

            //Console.WriteLine("Hay {0} personas", personas.Count);

            //Persona x = Persona.PersonaMasMayor(personas);//meto en la variable x a la persona mas mayor

            //Console.WriteLine("La persona mas mayor es \n" + x);//devuelve la persona mas mayor




            //for (int i = 0; i < personas.Count; i++)
            //{
            //    Console.WriteLine(personas[i]);
            //}

            ////foreach(Persona p in personas)
            ////{
            ////    Console.WriteLine(p);
            ////}

            //Dictionary<string, Persona> PersonasPorDNI = new Dictionary<string, Persona>();

            //PersonasPorDNI.Add(p1.DNI, p1);
            //PersonasPorDNI.Add(p2.DNI, p2);
            //PersonasPorDNI.Add(p3.DNI, p3);

            //Console.WriteLine("Hay {0} personas", PersonasPorDNI.Count);

            //foreach (string dni in PersonasPorDNI.Keys)//recorremos las claves del diccionario PersonasPorDNi
            //{
            //    Console.WriteLine(string.Format("---> Para el dni numero {0}: ", dni));//Para imprimir cada persona
            //    Persona p = PersonasPorDNI[dni];
            //    Console.WriteLine(p);
            //}



            //Console.WriteLine("Introduce un dni: ");//Para preguntar por un dni y que devuelva la persona
            //string r = Console.ReadLine();
            //Console.WriteLine(PersonasPorDNI[r]);

            #endregion



            #region Pruebas

            //Evento[] EEstudios = new Evento[1]; //creo un array de EEstudios, que solo va a tener 1 estudio
            //EEstudios[0] = new Evento("Teleco", 2, "Los Viveros");//aqui le doy los datos del estudio creado arriba (nombre, años, lugar)
            //Evento[] EExperiencia = new Evento[1];
            //EExperiencia[0] = new Evento("Soldador", 3, "Fabrica Cocacola");


            //Candidato C1 = new Candidato("jorge", "Garcia", 23, 0, "74784737Z", "Soldador", null, 3.3f);//la parte del cv lo dejo en null, para despues crear el CV.

            //CV cv = new CV(EEstudios, EExperiencia, C1);//creo el cv

            //C1.SetCV(cv);//añado el cv creado al candidato.








            //Console.WriteLine(C1);

            #endregion



            Tests.DoTest();


            Console.ReadLine();


        }




    }
}

