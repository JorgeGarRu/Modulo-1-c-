using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public static class Musify
    {
        //propiedades
        private static List<Song> songs;

        public static List<Song> Songs
        {
            get { return songs; }
            set { songs = value; }
        }

        private static List<Playlist> playlists;

        public static List<Playlist> Playlists
        {
            get { return playlists; }
            set { playlists = value; }
        }

        public static void Export()
        {
            //convertir todas las canciones en string con el formato
            string songData = ConvertSongsToString();
            //convertir todas las playlist en string con el formato

            //escribir en el fichero los datos anteriores separados por el patron *+++*

        }

        public static void Import()
        {

        }

        //funcionalidades
        public static Song CancionMasAntigua(string nombrePlaylist)
        {

            Song res = null;
            Playlist lista = DevuelveNombrePlaylist(nombrePlaylist);
         
                foreach (Song s in lista.Songs)
                {
                    if (res == null || s.Year < res.Year)
                    {
                        res = s;
                    }
                }
            
            return res;
        }

        //public static bool ExisteCancion(string nombreCancion, string nombreAutor)
        //{
        //    bool res = false;
        //    foreach (Song s in Songs)
        //    {
        //        if(s.Name == nombreCancion && s.Author == nombreAutor)
        //        {
        //            res = true;
        //            break;
        //        }

        //    }
        //    return res;
        //}

        public static int NumeroCancionesGenero(Genre genre,string nombrePlaylist)
        {
            int res = 0;
            Playlist lista = DevuelveNombrePlaylist(nombrePlaylist);
            foreach(Song s in lista.Songs)
            {
                if(s.Genre == genre)
                {
                    res++;
                }
            }
            return res;
        }

        public static Song CancionMejorValorada(string nombrePlaylist)
        {
            Song res = null;
            Playlist lista = DevuelveNombrePlaylist(nombrePlaylist);
            foreach(Song s in lista.Songs)
            {
                if(res == null || s.Score > res.Score)
                {
                    res = s;
                }
            }
            return res;
        }

        //funciones auxiliares
        private static Playlist DevuelveNombrePlaylist(string name)//metodo para devolver la playlist mediante el nombre de dicha playlist.
        {
            Playlist res = null;

            foreach(Playlist p in Playlists)
            {
                if(p.Name == name)
                {
                    res = p;
                    break;
                }
            }
            return res;
        }

        private static string ConvertSongsToString()//metodo para convertir todas las canciones en string
        {
            string data = "";
            foreach(Song s in Songs)
            {
                string songData = "";
                songData = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", s.Name, s.Author, s.Duration, s.Year, s.Genre, s.Score);
                songData += "\n";//para ir separando por linea cada cancion.
                data += songData;//lo voy guardando el data
            }

            return data;
        }

        private static string ConvertPlayListsToString()//metodo para convertir todas las playlists en string
        {
            string data = "";//inicializo la variable data que devolvera todo el texto
            foreach (Playlist p in Playlists)//recorro las listas de cada playlists
            {
                string playListData = "";//inicializo la variable que tendra el formato de cada linea
                string playListName = p.Name;//
                string songlist = "";//inicializo la variable que tendra el formato de cada cancion con su nombre y autor
                foreach(Song s in p.Songs)//recorro las canciones de la lista de canciones del playlist que estamso recorriendo
                {
                    string songData = s.Name + ":" + s.Author;
                    songlist += songData + ",";
                }

                playListData = playListName + "-" + songlist;
                data += playListData + "\n";

               
            }

            return data;
        }

        public static void Realizartest()
        {
            Song s1 = new Song("Bamboleo", "Gipsy King", 2, 1998, Genre.Latin, 5);
            Song s2 = new Song("Bamboleo", "Gipsy King", 2, 1994, Genre.Latin, 5);
            Song s3 = new Song("jkhfg", "Gipsy King", 2, 1991, Genre.Latin, 5);

            List<Song> songs = new List<Song>();
            songs.Add(s1);
            songs.Add(s2);
            songs.Add(s3);

            //Console.WriteLine(Musify.CancionMasAntigua());
            //Musify.ExisteCancion("Bamboleo", "Gipsy King");

            Playlist lista1 = new Playlist("Lista 1", songs);
            //Console.WriteLine(lista1);

            Console.WriteLine(Musify.CancionMasAntigua("Lista 1"));

            //List<Song> songs1 = new List<Song>();
            //songs1.Add(s1);
            //songs1.Add(s2);
            //songs1.Add(s3);


            //Playlist lista2 = new Playlist("Lista 1", songs1.Count, songs1);
            //Console.WriteLine(lista2);
            //Console.WriteLine(lista1.Equals(lista2));



            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
    }


