using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class Candidato:Persona
    {
        //miembros
        #region Miembros

        //string puesto;
        //CV cv;
        //float valoracion;
        #endregion

        //Propiedades
        #region Propiedades

        private string puesto;

        public string Puesto
        {
            get { return puesto; }
            set { this.puesto = value; }
        }

        private CV cv;

        public CV CV
        {
            get { return cv; }
            set { this.cv = value; }
        }

        private float valoracion;

        public float Valoracion
        {
            get { return valoracion; }
            set
            {
                if (valoracion >= 0.0f && valoracion <= 1.0f)
                {
                    this.valoracion = value;
                }
            }

        }

        #endregion


        //getters y setters
        #region Getters y Setters

        //public string GetPuesto()
        //{
        //    return puesto;
        //}

        //public void SetPuesto(string puesto)
        //{
        //    this.puesto = puesto;
        //}

        //public CV GetCV()
        //{
        //    return cv;
        //}

        //public void SetCV(CV cv)
        //{
        //    this.cv = cv;
        //}

        //public float GetValoracion()
        //{
        //    return valoracion;
        //}

        //public void SetValoracion(float valoracion)
        //{
        //    if(valoracion>=0.0f && valoracion <= 1.0f)
        //    {
        //        this.valoracion = valoracion;
        //    } else
        //    {
        //        Console.WriteLine("Debe estar comprendido entre 0.0 y 1.0");
        //    }
        //}
        #endregion

        //constructores
        #region Constructores

        public Candidato() //constructor por defecto
        {

        }

        public Candidato(string nombre, string apellidos, int edad, Sexo sexo, string dni, string puesto, CV cv, float valoracion) : base(nombre, apellidos, edad, sexo, dni)
        {
            this.puesto = puesto;
            this.cv = cv;
            this.valoracion = valoracion;
        }

        public Candidato(string datos) : base(datos) //con el "base" llamamos al constructor string de la clase Padre
        {
            string[] candidatoSplit = datos.Split(',');


            this.puesto = candidatoSplit[5];
            this.cv = null;
            this.valoracion = 0f;
        }
        #endregion


        public override string ToString()
        {

            string s = base.ToString();
            return s + "\nPuesto: " + Puesto + "\n" + CV + "\nValoracion: " + Valoracion;
        }

        //equals
        public bool Equals(object o)
        {
            if (o is Candidato)
            {
                Candidato aux = (Candidato)o;

                return this.DNI == aux.DNI;
            }
            else
            {
                return false;
            }
        }
    }
}
