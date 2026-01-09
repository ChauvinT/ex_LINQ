using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_LINQ
{
    internal class Dog
    {
        public string Race;
        public string Nom;
        public int Age;
        public int Poids;

        public Dog(string race, string nom, int age, int poids) 
        { 
            Race = race;
            Nom = nom;
            Age = age;
            Poids = poids;
        }

        public override string ToString()
        {
            return $"{Nom} est un {Race} de {Age} an(s) pèsant {Poids} kilo(s)";
        }
    }
}
