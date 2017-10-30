using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class Playlist
    {
        //propiedades
        #region propiedades

        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }



        public int SongCount//propiedad derivada, por lo tanto no necesita variable
        {
            get { return Songs.Count; }//devuelve el numero total de la lista de canciones.

        }

        private List<Song> songs = new List<Song>();

        public List<Song> Songs
        {
            get { return songs; }
            set { this.songs = value; }
        }




        #endregion

        //COnstructores
        #region Constructores

        public Playlist()
        {
            this.name = "";
            this.songs = new List<Song>();

        }

        public Playlist(string name, List<Song> songs)
        {
            this.name = name;
            

            this.songs = songs;
        }

        public Playlist(string datos)
        {
            string[] playlistSplit = datos.Split('-');
            name = playlistSplit[0];
            string[] songsSplit = playlistSplit[1].Split(',');
            songs = new List<Song>();
            foreach(string songString in songsSplit)
            {
                string[] songsSplit1 = songString.Split(':');
                string songName = songsSplit1[0];
                string authorName = songsSplit1[1];
                Song song = Musify.GetSongByNameAndAuthor(songName, authorName);
                songs.Add(song);
                
            }
        }



        #endregion

        public override bool Equals(object o)
        {
            //    if (o is Playlist)
            //    {
            //        Playlist other = (Playlist)o;
            //        bool res = this.Name == other.Name;
            //        if (res && this.SongCount == other.SongCount)
            //        {
            //            foreach (Song mySong in Songs)
            //            {
            //                if (!other.Songs.Contains(mySong))
            //                {
            //                    res = false;
            //                    break;
            //                }
            //            }
            //        }


            //        return res;
            //    } else {
            //        return false;
            //    }
            //}

            if (o is Playlist)
            {
                Playlist aux = (Playlist)o;



                return this.Name == aux.Name && this.songs.SequenceEqual(aux.songs);


            }
            return false;
        }



        public override string ToString()
        {
            string s = string.Format("--- {0} ---\n", Name);

            foreach (Song p in Songs)
            {

                s = s + string.Format("  - {0}\n", p);


            }
            return s;


        }

        //Mutators

        public int TotalDuration()
        {
            int tiempo = 0;
            foreach (Song p in songs)
            {
                tiempo += p.Duration;
            }

            return tiempo;
        }

        public float AverageScore()
        {
            float acum = 0;

            foreach (Song p in songs)
            {
                acum += p.Score;

            }
            return acum / songs.Count;
        }
    }
}

