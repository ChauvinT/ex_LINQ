using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_LINQ
{
    internal class Personne
    {
        public string Nom;
        public string Prenom;
        public int Age;
        public string Sexe;
        public bool EstIngénieur;
        public Personne(string nom, string prenom, bool estIngénieur) 
        { 
            Nom = nom;
            Prenom = prenom;
            EstIngénieur = estIngénieur;
        }
        public Personne(string nom, string prenom, int age, string sexe) 
        { 
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Sexe = sexe;
        }
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        public override string ToString()
        {
            return $"{Prenom} {Nom}";
        }
    }
}
