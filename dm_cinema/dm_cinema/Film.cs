using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Film
    {
        private int annee, idFilm;
        private string genre, resume, titre;
        private Acteur acteurPrincipal;

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public int IdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public Film()
        {
        }

        public Film(int idFilm, string titre, string genre, int annee, string resume)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;
        }

        public static Film getInstance(int idFilm, string titre, string genre, int annee, string resume)
        {
            return new Film(idFilm,titre, genre, annee, resume );
        }

        public Acteur GetActeurPrincipal()
        {
            return acteurPrincipal;
        }

        public override string ToString()
        {
            return $"Titre : {titre} Année : {annee} Genre : {genre} Résumé : {resume}";
        }
    }
}
