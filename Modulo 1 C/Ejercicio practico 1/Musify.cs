using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modulo_1_C
{
    public static class Musify
    {

        private const string PATH = "../../Resources/musify.txt";

        //propiedades
        #region Propiedades
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

#endregion

        public static void Export()
        {
            
            //convertir todas las canciones en string con el formato
            string songData = ConvertSongsToString();
            //convertir todas las playlist en string con el formato
            string playlistData = ConvertPlayListsToString();
            //escribir en el fichero los datos anteriores separados por el patron *+++*
            try
            {
                //string path = "../../Resources/musify.txt";
                StreamWriter file = File.CreateText(PATH);
                string completeData = songData + "\n*+++*\n" + playlistData;
                file.Write(completeData);
                file.Close();
                Console.WriteLine("Datos exportados correctamente");


            }
            catch (Exception e)
            {

                Console.WriteLine("Error al exportar los datos"+e);
            }
           

        }

        public static void Import()
        {
            List <string> lines = ReadFile(PATH);

            List<string> songsLines = new List<string>();//lista que contendra las canciones del fichero
            List<string> playlistLines = new List<string>();//lista que contendra las listas del fichero
            bool isPlaylist = false; // variables para saber cuando pasamos a la parte de listas
            foreach(string line in lines)
            {
                if (line == "*+++*")//si la linea es ese patron..
                {
                    isPlaylist = true;
                }
                else
                {
                    if (!isPlaylist)//en caso de que la linea no sea una cancion..
                    {
                        songsLines.Add(line);
                    }
                    else
                    {
                        playlistLines.Add(line);
                    }
                }
            }

            Songs = new List<Song>(); //vacío la lista de canciones
            Playlists = new List<Playlist>();//vacío la lista de playlits
            foreach(string line in songsLines)
            {
                Song s = new Song(line);//llamo al constructor tostring de Song 
                Songs.Add(s);
            }

            foreach(string line in playlistLines)
            {
                Playlist p = new Playlist(line);
                Playlists.Add(p);
            }

        }

        //funcionalidades
        #region Funcionalidades
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

        public static bool ExisteCancion(string nombreCancion, string nombreAutor)
        {
            bool res = false;
            foreach (Song s in Songs)
            {
                if (s.Name == nombreCancion && s.Author == nombreAutor)
                {
                    res = true;
                    break;
                }

            }
            return res;
        }

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

        public static int DuracionTotal(string nombrePlaylist)
        {
            int acum = 0;
            Playlist playlist = DevuelveNombrePlaylist(nombrePlaylist);
            foreach(Song s in playlist.Songs)
            {
                acum += s.Duration;
                
            }
            return acum;
        }

        public static Playlist ListaFavorita()
        {
           
            Playlist listaFavorita = new Playlist();
            List<Song> cancionesFavoritas = new List<Song>();
            foreach(Song s in Songs)
            {
                if (s.Score >= 4)
                {
                    cancionesFavoritas.Add(s);
                }
                
                listaFavorita.Songs = cancionesFavoritas;
                
                
            }

            Console.WriteLine("Canciones favoritas:\n");
            return listaFavorita;
        }

        #endregion

        //funciones auxiliares
        #region Funciones auxiliares

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
                songData = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", s.Name, s.Author, s.Duration, s.Year, (int) s.Genre, s.Score);
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

        private static List<string> ReadFile(string path)
        {
            List<string> lines = new List<string>();

            try
            {
                StreamReader file = File.OpenText(PATH);
                string line = "";
                while(line != null)
                {
                    line = file.ReadLine();
                    if (line != null)//este if es para que cuando sea ya la ultima linea, no añada mas.
                    {
                        lines.Add(line);
                    }
                }
                file.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error al leer el archivo");
            }
            return lines;
        }

        public static Song GetSongByNameAndAuthor(string name, string author)//metodo para buscar una cancion dado el nombre y el autor
        {
            Song res = null;
            foreach(Song s in Songs)
            {
                if(s.Name == name && s.Author == author)
                {
                    res = s;
                }
            }
            return res;
        }

#endregion







    }
    }
    


