using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_LINQ
{
    internal class Chien
    {
        public string Nom;
        public string Surnom;
        public string Race;
        public string Couleur;
        public string Genre;
        public int Age;
        public int Poids;

        public Chien(string nom, string surnom, string race, string couleur, string genre, int age, int poids)
        {
            Nom = nom;
            Surnom = surnom;
            Race = race;
            Couleur = couleur;
            Genre = genre;
            Age = age;
            Poids = poids;
        }

        public override string ToString()
        {
            return $"{Nom} est un {Race} de {Age} an(s) pèsant {Poids} kilo(s)";
        }
    }
}
