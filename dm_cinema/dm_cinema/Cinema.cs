using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Cinema
    {
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;
        private Cinema cinema;

        public Cinema(Cinema cinema, List<Film> LesFilms, List<Acteur> LesActeurs)
        {
            this.cinema = cinema;
            this.LesActeurs = LesActeurs;
            this.LesFilms = LesFilms;
        }

        public Cinema()
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilms = new List<Film>();
        }

        public static Cinema GetInstance()
        {
            return new Cinema();
        }

        public void AjouterActeur(Acteur acteur)
        {
            lesActeurs.Add(acteur);
        }

        public void AjouterFilm(Film film)
        {
            lesFilms.Add(film);
        }

        public Acteur GetActeur(int id)
        {
            return LesActeurs[id];
        }

        public Film GetFilm(int id)
        {
            return LesFilms[id];
        }

        public List<Acteur> NbActeurs()
        {
            return LesActeurs;
        }

        public List<Film> NbFilms()
        {
            return LesFilms;
        }
    }
}
