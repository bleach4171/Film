using System;

namespace Filme
{
    class Film
    {
        // Variablen Daten
        private string Title;
        private int Erscheinungsjahr;
        private string Genre;
        private double Laufzeit;
        private string[] Cast;
        private string Sprache;
        private int FSK;

        // Konstruktor titel und erscheinungsjahr
        public Film(string title, int erscheinungsjahr)
        {
            Title = title;
            Erscheinungsjahr = erscheinungsjahr;
            Genre = "";
            Laufzeit = 0;
            Cast = [];
            Sprache = "";
            FSK = 0;
        }

        // Konstruktor titel 
        public Film(string title, int erscheinungsjahr, string genre, double laufzeit)
        {
            Title = title;
            Erscheinungsjahr = erscheinungsjahr;
            Genre = genre;
            Laufzeit = laufzeit;
            Cast = [];
            Sprache = "";
            FSK = 0;
        }

        // Konstruktor, der alle Felder übernimmt
        public Film(string title, int erscheinungsjahr, string genre, double laufzeit, string cast, string sprache, int fsk)
        {
            Title = title;
            Erscheinungsjahr = erscheinungsjahr;
            Genre = genre;
            Laufzeit = laufzeit;
            Cast = cast.Split('.');
            Sprache = sprache;
            FSK = fsk;
        }

        // Konstruktor, der nichts übernimmt und alle Felder initialisiert
        public Film()
        {
            Title = "";
            Erscheinungsjahr = 0;
            Genre = "";
            Laufzeit = 0;
            Cast = [];
            Sprache = "";
            FSK = 0;
        }

        // get und set für Title
        public string get_Title()
        {
            return Title;
        }
        public void set_Title(string title) { Title = title; }

        // get und set für Erscheinungsjahr
        public int get_Erscheinungsjahr()
        {
            return Erscheinungsjahr;
        }
        public void set_Erscheinungsjahr(int erscheinungsjahr) { Erscheinungsjahr = erscheinungsjahr; }

        // get und set für Genre
        public string get_Genre()
        {
            return Genre;
        }
        public void set_Genre(string genre) { Genre = genre; }

        // get und set für Laufzeit
        public double get_Laufzeit()
        {
            return Laufzeit;
        }

        // Rechnet Minuten in Stunden um
        public void set_Laufzeit(int laufzeit)
        {
            double hours = Convert.ToDouble($"{laufzeit / 60},{laufzeit % 60}");
            Laufzeit = (laufzeit > 60) ? hours : laufzeit;
        }

        // get und set für Cast
        public string get_Cast()
        {
            string castlist = "";
            if (Cast.Length > 0)
            {
                for (int i = 0; i < Cast.Length; i++)
                {
                    castlist += $"\n{Cast[i].ToString()}";
                }
            }
            return castlist;
        }
        public void set_Cast(string cast) { Cast = cast.Split('.'); }

        //get , set Sprache
        public string get_Sprache() { return Sprache; }
        public void set_Spracher(string sprache) { Sprache = sprache; }

        //get , set FSK
        public int get_FSK() { return FSK; }
        public void set_FSK(int fsk) { FSK = fsk; }
    }

    class Start
    {
        static void Main(string[] args)
        {
            // neues Objekt
            Film film = new Film();
            film.set_Title("Avengers: Endgame");
            film.set_Erscheinungsjahr(2019);
            film.set_Genre("Action");
            film.set_Laufzeit(181);
            film.set_Cast("Robert Downey Jr.Chris Evans.Mark Ruffalo.Chris Hemsworth.Scarlett Johansson.Jeremy Renner");

            Console.WriteLine(film.get_Title());
            Console.WriteLine(film.get_Erscheinungsjahr());
            Console.WriteLine(film.get_Genre());
            Console.WriteLine(film.get_Laufzeit() + " Stunden");
            Console.WriteLine(film.get_Cast());



            // Pause machen damit nicht automatisch schließt
            Console.ReadKey();
        }
    }
}