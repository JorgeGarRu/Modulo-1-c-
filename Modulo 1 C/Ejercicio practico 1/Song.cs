using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_C
{
    
        public enum Genre
        {
            Country,
            Electronic,
            Folk,
            HipHop,
            Jazz,
            Pop,
            Rock,
            Latin,
            Metal,
            Classic
        }


        public class Song
        {
            //Propiedades
            #region Propiedades
            private string name;

            public string Name
            {
                get { return name; }

            }

            private string author;

            public string Author
            {
                get { return author; }

            }

            private int duration;

            public int Duration
            {
                get
                {


                    return duration;

                }



            }

            private int year;

            public int Year
            {
                get { return year; }

            }

            private Genre genre;

            public Genre Genre
            {
                get { return genre; }

            }

            private int score;

            public int Score
            {
                get { return score; }
                set
                {

                    if (value >= 0 && value <= 5)
                    {
                        score = value;
                    }
                    else
                    {
                        Console.WriteLine("La puntuación debe estar comprendida entre 0 y 5");
                    }

                }
            }

            #endregion


            //Constructores
            #region Constructores
            public Song()
            {

            }

            public Song(string name, string author, int duration, int year, Genre genre)
            {
                this.name = name;
                this.author = author;
                if (duration > 0)
                {
                    this.duration = duration;
                }
                if (year >= 1800 && year <= 2017)
                {
                    this.year = year;
                }
                this.genre = genre;

                this.score = 0;

            }

            public Song(string name, string author, int duration, int year, Genre genre, int score) : this(name, author, duration, year, genre)
            {
                if (score >= 0 && score <= 5)
                {
                    this.score = score;
                }

            }

            public Song(string datos)
            {
                string[] songSplit = datos.Split('-');//separamos por guion porque a la hora de exportar en txt, nos pide que lo separemos por -
                name = songSplit[0];
                author = songSplit[1];
                duration = int.Parse(songSplit[2]);
                year = int.Parse(songSplit[3]);
                genre = (Genre)int.Parse(songSplit[4]);
                score = int.Parse(songSplit[5]);
            }




            #endregion

            //To Equals
            public override bool Equals(object o)
            {
                if (o is Song)
                {
                    Song aux = (Song)o;

                    return this.Name == aux.Name && this.Author == aux.Author;
                }
                else
                {
                    return false;
                }

            }

            public override string ToString()
            {
                string s = string.Format("{0} - ({1} - {2}).{3}", Name, Author, Year, Score);
                return s;
            }


        }
    }

