using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class Evento
    {
        //miembros
        #region Miembros
        //string nombre;
        //int tiempo;
        //string lugar;
        #endregion

        //Propiedades
        #region Propiedades
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        private int tiempo;

        public int Tiempo
        {
            get { return tiempo; }
            set { this.tiempo = value; }
        }

        private string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { this.lugar = value; }
        }




        #endregion

        //getters y setters
        #region Getters y Setters

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetTiempo()
        {
            return tiempo;
        }

        public void SetTiempo(int tiempo)
        {
            if (tiempo >= 0 && tiempo <= 100)
            {
                this.tiempo = tiempo;
            }
            else
            {
                Console.WriteLine("El tiempo debe estar comprendido entre 0 y 100 años");
            }
        }

        public string GetLugar()
        {
            return lugar;
        }

        public void SetLugar(string lugar)
        {
            this.lugar = lugar;
        }
        #endregion

        //constructores
        #region Constructores

        public Evento()
        {

        }

        public Evento(string nombre, int tiempo, string lugar)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.lugar = lugar;
        }

        public Evento(string datos)
        {
            string[] eventoSplit = datos.Split(',');

            this.nombre = eventoSplit[0];
            this.tiempo = int.Parse(eventoSplit[1]);
            this.lugar = eventoSplit[2];
        }
        #endregion

        public override string ToString()
        {
            string s = "Nombre: " + Nombre + "\nTiempo: " + Tiempo + "\nLugar: " + Lugar;
            return s;
        }

    }
}
