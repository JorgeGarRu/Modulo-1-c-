using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    public class Tests
    {
        public static void DoTest()
        {
            #region Ejemplo Imprimir por pantalla listas de playlists
            //Song song1 = new Song("Nombre 1", "Autor 1", 135, 1998, Genre.HipHop, 4);
            //Song song2 = new Song("Nombre 2", "Autor 2", 148, 2007, Genre.HipHop, 2);
            //Song song3 = new Song("Nombre 3", "Autor 3", 240, 2001, Genre.Metal, 5);
            //Song song4 = new Song("Nombre 4", "Autor 4", 68, 2012, Genre.Metal, 4);
            //Song song5 = new Song("Nombre 5", "Autor 5", 190,2008, Genre.Rock, 4);

            //List<Song> songsHipHop = new List<Song>() { song1, song2 };
            //Playlist playlist1 = new Playlist("Hip Hop 2017", songsHipHop);

            //List<Song> songsHardRock = new List<Song>() { song3, song4, song5 };
            //Playlist playlist2 = new Playlist("Rock & Metal", songsHardRock);

            //Musify.Songs = new List<Song>() { song1, song2, song3, song4, song5 };

            //Musify.Playlists = new List<Playlist>() { playlist1, playlist2 };

            //Console.WriteLine("Playlists de Musify");

            //foreach (Playlist p in Musify.Playlists)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Ejemplo Metodo convertir las canciones y listas en Strings

            Song song1 = new Song("Nombre 1", "Autor 1", 135, 1998, Genre.HipHop, 4);
            Song song2 = new Song("Nombre 2", "Autor 2", 148, 1992, Genre.HipHop, 2);
            Song song3 = new Song("Nombre 3", "Autor 3", 240, 2001, Genre.Metal, 5);
            Song song4 = new Song("Nombre 4", "Autor 4", 68, 1992, Genre.Metal, 4);
            Song song5 = new Song("Nombre 5", "Autor 5", 190, 2008, Genre.Rock, 4);

            List<Song> songsHipHop = new List<Song>() { song1, song2 };
            Playlist playlist1 = new Playlist("Hip Hop 2017", songsHipHop);

            List<Song> songsHardRock = new List<Song>() { song3, song4, song5 };
            Playlist playlist2 = new Playlist("Rock & Metal", songsHardRock);

            Musify.Songs = new List<Song>() { song1, song2, song3, song4, song5 };

            Musify.Playlists = new List<Playlist>() { playlist1, playlist2 };

            Musify.Export();
            Musify.Import();
            #endregion

            #region Ejemplo Funcionalides

            //Console.WriteLine(Musify.CancionMasAntigua("Hip Hop 2017"));
            //Console.WriteLine(Musify.CancionMasAntigua("Rock & Metal"));
            //Console.WriteLine(Musify.NumeroCancionesGenero(Genre.HipHop,"Hip Hop 2017"));
            //Console.WriteLine(Musify.NumeroCancionesGenero(Genre.Metal, "Rock & Metal"));
            //Console.WriteLine((Musify.ExisteCancion("Nombre 1","Autor 2")));
            //Console.WriteLine((Musify.CancionMejorValorada("Hip Hop 2017")));
            //Console.WriteLine(Musify.DuracionTotal("Hip Hop 2017"));
            //Console.WriteLine(Musify.ListaFavorita());

            #endregion
        }

    }
}
