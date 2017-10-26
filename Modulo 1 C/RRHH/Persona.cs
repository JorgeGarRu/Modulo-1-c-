using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public enum Sexo //enumerado Sexo...crear los enumerados siempre fuera de la clase
    {
        Hombre = 0,
        Mujer = 1
    }

    public class Persona
    {

        //Miembros
        #region Miembros

        //string nombre;
        //string apellidos;
        //int edad;
        //Sexo sexo;
        //string dni;
        #endregion

        //Propiedades
        #region Propiedades //es la forma de poner los getters y los setters mas resumido con sus respectivos miembros.
        private string nombre;

        public string Nombre
        { //poniendo "propf" y dandole a tabular 2 veces, se pone solo.


            get { return this.nombre; }
            set { this.nombre = value; }//value es el parametro de entrada.

        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { this.apellidos = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0)
                {
                    this.edad = value;
                    //edad = (value >= 0) ? this.edad = value:0;//otra forma de poner el if.
                }


            }
        }


        private Sexo sexo;

        public Sexo Sexo
        {
            get { return sexo; }
            set { this.sexo = value; }
        }


        private string dni;

        public string DNI
        {
            get { return dni; }
            set { this.dni = value; }
        }







        #endregion

        //Getters y setters
        #region Getters y Setters

        //public string GetNombre()
        //{
        //    return nombre;
        //}

        //public void SetNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}

        //public string GetApellidos()
        //{
        //    return apellidos;
        //}

        //public void SetApellidos(string apellidos)
        //{
        //    this.apellidos = apellidos;
        //}

        //public int GetEdad()
        //{
        //    return edad;
        //}

        //public void SetEdad(int edad)
        //{
        //    if(edad >= 0 && edad <= 120)
        //    {
        //        this.edad = edad;
        //    }else
        //    {
        //        Console.WriteLine("La edad debe estar comprendida entre 0 y 120 años");
        //    }
        //}

        //public Sexo GetSexo()
        //{
        //    return sexo;
        //}

        //public void SetSexo(Sexo sexo)
        //{
        //    this.sexo = sexo;
        //}

        //public string GetDNI()
        //{
        //    return dni;
        //}
        #endregion


        //constructores
        #region Constructores

        public Persona() //Constructor por defecto
        {

        }

        public Persona(string nombre, string apellidos, int edad, Sexo sexo, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            if (edad >= 0 && edad <= 120)
            {
                this.edad = edad;
            }
            else
            {
                Console.WriteLine("La edad debe estar comprendida entre 0 y 120");
            }

            this.sexo = sexo;
            this.dni = dni;
        }

        public Persona(string datos) //Constructor para crear instancias a partir de cadena de caracteres.
        {
            datos = datos.Replace(" ", "");
            string[] personaSplit = datos.Split(',');

            this.nombre = personaSplit[0];
            this.apellidos = personaSplit[1];
            this.edad = int.Parse(personaSplit[2]);
            this.sexo = (Sexo)(int.Parse(personaSplit[3]));
            this.dni = personaSplit[4];
        }
        #endregion


        public override string ToString()
        {

            string s = "Nombre: " + Nombre + "\nApellidos: " + Apellidos + "\nEdad: " + Edad + "\nSexo: " + Sexo + "\nDNI: " + DNI;
            return s;
        }


        //Equals
        public override bool Equals(object o) //metodo para comparar si 2 personas son iguales
        {
            if (o is Persona)
            {
                Persona aux = (Persona)o;//una vez que pasa que o es una persona, hacemos un casting a o para pasarlo a tipo Persona

                return this.DNI == aux.DNI;//Comparamos las Personas por su dni.
            }
            else
            {
                return false;
            }


        }

        public static Persona PersonaMasMayor(List<Persona> personas)//Algoritmo para saber que persona es la que mas edad tiene.
        {
            Persona res = null;
            //List<Persona> personas = new List<Persona>();

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


            }

            return res;
        }
    }
}


