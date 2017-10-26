using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class CV
    {
        //miembros
        #region Miembros
        //Evento[] estudios;
        //Evento[] experiencias;
        //Candidato candidato;
        #endregion

        //Propiedades
        #region Propiedades
        private Evento[] estudios;

        public Evento[] Estudios
        {
            get { return estudios; }
            set { this.estudios = value; }
        }

        private Evento[] experiencias;

        public Evento[] Experiencias
        {
            get { return experiencias; }
            set { this.experiencias = value; }
        }

        private Candidato candidato;

        public Candidato Candidato
        {
            get { return candidato; }
            set { this.candidato = value; }
        }



        #endregion

        //getters y setters
        #region Getters y Setters

        //public Evento[] GetEstudios()
        //{
        //    return estudios;
        //}

        //public void SetEstudios(Evento[] estudios)
        //{
        //    this.estudios = estudios;
        //}

        //public Evento[] GetExperiencia()
        //{
        //    return experiencias;
        //}

        //public void SetExperiencia(Evento[] experiencia)
        //{
        //    this.experiencias = experiencia;
        //}

        //public Candidato GetCandidato()
        //{
        //    return candidato;
        //}
        #endregion

        //constructores
        #region Constructores

        public CV() //constructor por defecto
        {

        }

        public CV(Evento[] estudios, Evento[] experiencia, Candidato candidato)
        {
            this.estudios = estudios;
            this.experiencias = experiencia;
            this.candidato = candidato;
        }

        #endregion



        public override string ToString()
        {


            string s = "\n==========Curriculum==========\n\n";

            for (int i = 0; i < estudios.Length; i++)//recorremos el array estudios
            {
                int p = i + 1;//al indice le vamos sumando 1 para ir contando 
                s = s + "Estudio " + p + ":\n\n" + estudios[i] + "\n\n";//tambien se puede poner --> s+=estudios;
            }

            //    foreach(Evento estudio in estudios)//recorro el array estudios
            //{


            //    s = s + "Estudios: " + p + "\n\n" + estudio + "\n\n";//tambien se puede poner --> s+=estudios;
            //}
            for (int i = 0; i < experiencias.Length; i++)
            {
                int p = i + 1;
                s = s + "Experiencia laboral " + p + ":\n\n" + experiencias[i] + "\n";
            }


            //foreach (Evento experiencia in experiencias)
            //{
            //    s = s + "Experiencias laborales:\n\n" + experiencia + "\n";
            //}

            return s;






        }
    }
}
