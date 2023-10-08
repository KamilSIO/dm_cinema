using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Acteur
    {
        private int id, anneeNaiss;
        private string nom, prenom;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int AnneeNaiss
        {
            get { return anneeNaiss; }
            set { anneeNaiss = value; }
        }

        public Acteur()
        {
        }

        public Acteur(int id, string nom, string prenom, int anneeNaiss)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaiss = anneeNaiss;
        }

        public void GetInstance()
        {
            Acteur a = new Acteur();
        }

        public override string ToString()
        {
            return $"Nom : {nom} Prénom : {prenom} Année de naissance : {anneeNaiss}";
        }
    }
}