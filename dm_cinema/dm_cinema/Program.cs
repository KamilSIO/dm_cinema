using dm_cinema;
using System;

public class Program
{
    public static void Main()
    {
        Film monfilm = new Film();

        Cinema monCine = new Cinema();

        // Ajout des acteurs
        Acteur acteur1 = new Acteur(1234, "Ford", "Harisson", 1942);
        Acteur acteur2 = new Acteur(4567, "Hanks", "Tom", 1956);

        monCine.AjouterActeur(acteur1);
        monCine.AjouterActeur(acteur2);

        // Ajout des films
        Film film1 = new Film(4854, "Blade Runner", "Science-Fiction", 1982, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).");

        Film film2 = new Film(1225, "Toy Story", "Animation", 1992, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.");

        monCine.AjouterFilm(film1);
        monCine.AjouterFilm(film2);

        Console.WriteLine("Caractréistique films :");
        foreach (Film film in monCine.NbFilms())
        {
            Console.WriteLine(film.ToString());
            Console.WriteLine();
        }
    }
}