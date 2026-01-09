using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Principal;

namespace ex_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercice 2
            /*List<int> entiers = new List<int> { 4, 5, 2, 3, 1, 1, 0, 5, 8, 9, 10, 15, 16, 20, 21, 4, 5 };

            // 1 //
            var nombresVoulus = from n in entiers
                                where n > 5
                                select n;

            Console.WriteLine("\n1. Récupérer et afficher tous les nombres supérieurs à 5 \n");
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine(n);
            }

            // 2 //
            nombresVoulus = from n in entiers
                            where n >= 15 && n <= 20
                            select n;
            Console.WriteLine("\n2. Récupérer et afficher les nombres supérieurs ou égaux à 15 et inférieurs à 20\n");
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine(n);
            }

            // 3 //
            nombresVoulus = from n in entiers
                            where n > 2 && n % 2 == 0 && n < 20 && n != 8
                            select n;
            Console.WriteLine("\n3. Récupérer et afficher les nombres supérieurs à 2, qui sont des multiples de 2, inférieurs à 20, différents de 8\n");
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine(n);
            }

            // 4 //
            List<string> fruits = new List<string> { "Banane", "Ananas", "Cerise", "Framboise", "Groseilles", "Pomme", "Poire", "Tomate", "Kiwi", "Raisin", "Mangue", "Datte" };
            var fruitsVoulus = from s in fruits
                               where s.Length > 5
                               select s;
            Console.WriteLine("\n4. Récupérer et afficher tous les fruits dont le nom contient plus de 5 lettres\n");
            foreach (var s in fruitsVoulus)
            {
                Console.WriteLine(s);
            }

            // 5 //
            fruitsVoulus = from s in fruits
                           where s[0].ToString() == "P" && s.Length > 4 && s.Contains("o") && !s.Contains("m")
                           select s;
            Console.WriteLine("\n5. Récupérer et afficher tous les fruits dont le nom commence par \"P\", dont la longueur du nom est supérieure à 4, qui contiennent un \"o\" mais pas de \"m\"\n");
            foreach (var s in fruitsVoulus)
            {
                Console.WriteLine(s);
            }

            // 6 //
            fruitsVoulus = from s in fruits
                           orderby s.Length
                           select s;
            Console.WriteLine("\n6. Trier et afficher les fruits selon leur longueur\n");
            foreach (var s in fruitsVoulus)
            {
                Console.WriteLine(s);
            }
            */

            // Exercice 2
            /*List<Dog> dogs = new List<Dog>
            {
            new Dog("Berger Australien", "Banzaï", 1, 28),
            new Dog("Berger Australien", "Letto", 3, 30),
            new Dog("Berger Australien", "Princesse", 8, 32),
            new Dog("Berger Allemand", "Floyd", 10, 32),
            new Dog("Caniche", "Igor", 13, 9),
            new Dog("Labrador", "Swing", 15, 25),
            new Dog("Teckel", "Wonki", 2, 5),
            new Dog("Terre Neuve", "Albator", 1, 50),
            new Dog("Carlin", "Pataud", 13, 10),
            new Dog("Boxer", "Frank", 6, 25),
            new Dog("Lévrier Afghan", "Précieuse", 9, 26),
            new Dog("Yorkshire", "Kakou", 3, 6)
            };

            // 1 //
            var animauxVoulus = from s in dogs
                           where s.Race == "Berger Australien"
                           select s;
            Console.WriteLine("\n1. Récupérer et afficher tous les noms des chiens qui sont de la race \"Berger Australien\n");
            foreach (var s in animauxVoulus)
            {
                Console.WriteLine(s.ToString());
            }

            // 2 //
            animauxVoulus = from s in dogs
                                where s.Race == "Berger Australien"
                                orderby s.Nom
                                select s;
            Console.WriteLine("\n2. Récupérer et afficher tous les noms des chiens qui sont de la race \"Berger Australien\" et les trier par leur nom\n");
            foreach (var s in animauxVoulus)
            {
                Console.WriteLine(s.ToString());
            }

            // 3 //
            animauxVoulus = from s in dogs
                            where s.Age >= 5 && s.Nom.Length > 5
                            select s;
            Console.WriteLine("\n3. Récupérer et afficher tous les noms des chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 lettres\n");
            foreach (var s in animauxVoulus)
            {
                Console.WriteLine(s.ToString());
            }

            // 4 //
            animauxVoulus = from s in dogs
                            where s.Age >= 5 && s.Nom.Length > 5
                            orderby s.Poids
                            select s;
            Console.WriteLine("\n4. Les trier par leur poids\n");
            foreach (var s in animauxVoulus)
            {
                Console.WriteLine(s.ToString());
            }

            // 5 //
            animauxVoulus = from s in dogs
                            orderby s.Age descending, s.Poids
                            select s;
            Console.WriteLine("\n5. Récupérer et afficher tous les noms des chiens par leur âge (tri décroissant) puis leur poids (tri croissant)\n");
            foreach (var s in animauxVoulus)
            {
                Console.WriteLine(s.ToString());
            }

            // 6 //
            animauxVoulus = from s in dogs
                            where !s.Race.Contains(" ") && s.Poids > 15 && s.Nom.Contains("i")
                            orderby s.Nom.Length
                            select s;
            Console.WriteLine("\n6. Récupérer et afficher tous les noms des chiens dont le nom de race tient en un seul mot, leur poids doit être supérieur à 15 kilos, leur nom doit contenir un \"i\" et les trier par la longueur de leur prénom.\n");
            foreach (var s in animauxVoulus)
            {
                Console.WriteLine(s.ToString());
            }
            */

            // Exercice3
            /*
            List<Personne> personnes = new List<Personne>
            {
            new Personne("Hallyday", "Johnny", false),
            new Personne("Vartan", "Sylvie", false),
            new Personne("Drucker", "Michel", false),
            new Personne("Antoine", "Antoine", true),
            new Personne("Philippe", "Edouard", false),
            new Personne("Demorand", "Patricia", true),
            new Personne("Ulysse", "Margareth", true),
            new Personne("Zenith", "Méryl", true),
            new Personne("Bobo", "Jojo", false)
            };

            // 6 //
            var personneVoulus = from s in personnes
                                 orderby s.Nom, s.Prenom
                                 select s;
            Console.WriteLine("\n1. Créer un itérable d'ingénieurs, trier par nom, et ensuite par prénom\n");

            List<GroupeIngenieur> listIngénieurs = new List<GroupeIngenieur>();

            foreach (var s in personneVoulus)
            {
                Console.WriteLine(s);
                //listIngénieurs.Add(s);
            }

            IEnumerable<object> enumerator = listIngénieurs;

            // 7 //
            personneVoulus = from s in personnes
                             where !s.EstIngénieur
                             orderby s.Nom, s.Prenom
                             select s;
            Console.WriteLine("\n2. Récupérer et afficher la liste des personnes qui ne sont pas ingénieures\n");
            foreach (var s in personneVoulus)
            {
                Console.WriteLine(s.ToString());
            }

            // 7 //
            personneVoulus = from s in personnes
                             orderby s.EstIngénieur
                             select s;
            Console.WriteLine("\n3. Créer une liste d'objets anonymes (Ingénieurs + techniciens)\n");
            foreach (var s in personneVoulus)
            {
                Console.WriteLine(s.ToString());
            }
            */

            // Exercice4
            /*
            List<Personne> personnes = new List<Personne>
            {
            new Personne("Beauvoir", "Simon", 16, "M"),
            new Personne("Beauvoir", "Simone", 25, "F"),
            new Personne("De Caunes", "Richard", 41, "M"),
            new Personne("Sullivan", "Sullivan", 31, "M"),
            new Personne("Rémy", "Camille", 22, "F"),
            new Personne("Manchon", "Camille", 19, "M"),
            new Personne("Thiebaud", "Marie", 61, "F"),
            new Personne("Crouchon", "Mélanie", 55, "F"),
            new Personne("Baline", "Mélodie", 74, "F"),
            new Personne("Karine", "Pascal", 31, "M"),
            new Personne("Katherine", "Pascale", 36, "F"),
            new Personne("Zoula", "Charles", 20, "M"),
            new Personne("Romain", "Collin", 34, "M"),
            new Personne("Fouchard", "Aïcha", 48, "F"),
            new Personne("Blandine", "Maëva", 18, "F")
            };

            // 1 //
            var personneVoulus = from s in personnes
                                 let nom_complet = s.Nom + " " + s.Prenom
                                 select $"{nom_complet}";
            Console.WriteLine("\n1. Créer une variable nom_complet = Nom +\" \"+ Prenom et la mettre comme seule attribut de l'objet créé dans le select et les afficher\n");
            foreach (var s in personneVoulus)
            {
                Console.WriteLine(s);
            }

            // 2 //
            personneVoulus = from s in personnes
                             where s.Age >= 18 && s.Age < 50
                             let initiale = s.Nom[0] + "." + s.Prenom[0]
                             let taille_nom_complet = s.Nom.Length + s.Prenom.Length
                             select $"{s.Nom} {s.Prenom} {initiale} {taille_nom_complet} {s.Age}";
            Console.WriteLine("\n2. Pour les personnes majeures ayant moins de 50 ans :\n");
            foreach (var s in personneVoulus)
            {
                Console.WriteLine(s);
            }
            */

            // Exercice5
            /*
            List<List<Personne>> personnes = new List<List<Personne>>
            {
            new List<Personne> {new Personne("Drucker", "Michel"),
                        new Personne("Bedia", "Ramzy"),
                        new Personne("Judor", "Eric")},
            new List<Personne> {new Personne("Diaz", "Cameron"),
                        new Personne("Depardieu", "Gerard"),
                        new Personne("Stallone", "Sylvester"),
                        new Personne("Macron", "Emmanuel")},
            new List<Personne> {new Personne("Benzema", "Karim"),
                        new Personne("Antoine", "Eric"),
                        new Personne("Ruiz", "Olivia"),
                        new Personne("Clavier", "Christian"),
                        new Personne("Einstein", "Albert")}
            };

            // 1 //
            var personneVoulus = from liste in personnes
                                 from p in liste
                                 where p.Nom.Length > 5
                                 select p;
            Console.WriteLine("\n1. 1.Récupérer et afficher tous les noms dont la longueur est supérieure à 5\n");
            foreach (var s in personneVoulus)
            {
                Console.WriteLine(s);
            }

            // 2 //
            var personneVoulus_2 = from liste in personnes
                             from p in liste
                             let identite = p.Nom + " " + p.Prenom
                             where (p.Nom.Contains("a") || p.Nom.Contains("A")) && (p.Prenom.Contains("e") || p.Prenom.Contains("E"))
                             orderby p.Nom descending
                             select $"{identite}";
            ;
            Console.WriteLine("\n1. 2.Récupérer toutes personnes dont le nom contient un \"e\" et dont le prénom contient un \"a\"\n");
            foreach (var s in personneVoulus_2)
            {
                Console.WriteLine(s);
            }

            // 3 //
            var personneVoulus_3 = from liste in personnes
                                   from p in liste
                                   let initiale = p.Prenom[0] + "." + p.Nom[0]
                                   where liste.Count > 4 && p.Nom[0].ToString() == "A"
                                   orderby p.Prenom
                                   select $"{initiale}";
            ;
            ;
            Console.WriteLine("\n1. 3.Récupérer toutes les listes qui contiennent plus de 4 personnes\n");
            foreach (var s in personneVoulus_3)
            {
                Console.WriteLine(s);
            }

            // 4 //
            var personneVoulus_4 = from liste in personnes
                                   from p in liste
                                   let identite = p.Nom + " " + p.Prenom
                                   where liste.Count < 5
                                   orderby p.Prenom
                                   select $"{identite}";
            ;
            ;
            Console.WriteLine("\n1. 4.Récupérer toutes les listes qui contiennent moins de 5 personnes et afficher toutes les personnes comme ceci : Nom+\" \"+Prenom\n");
            foreach (var s in personneVoulus_4)
            {
                Console.WriteLine(s);
            }
            */

            /*
            //Exercice6
            List<Personne> personnes = new List<Personne>()
            {
                new Personne("Garett", "Ramzy", 45, "M"),
                new Personne("Caire", "Joe", 35, "M"),
                new Personne("Clay", "Alicia", 18, "F"),
                new Personne("Bavette", "Simone", 68, "F"),
                new Personne("Henry", "Thierry", 44, "M"),
                new Personne("Jacquesonne", "Janett", 25, "F"),
                new Personne("Buveur", "Joe", 25, "M"),
                new Personne("Louet", "Karim", 31, "M"),
                new Personne("Louette", "Karima", 31, "F"),
                new Personne("Caire", "Paul", 19, "M"),
                new Personne("Mille", "Camille", 20, "F"),
                new Personne("Cent", "Camille", 40, "F"),
                new Personne("Million", "Camille", 60, "M"),
                new Personne("Gold", "Roger", 17, "M"),
                new Personne("Lion", "Sandra", 8, "F"),
                new Personne("René", "Jean", 6, "M")
            };

            // 1 //
            var personneVoulus1 = personnes.GroupBy(
                                    personne => personne.Sexe,
                                    personne => personne,
                                    (sexe, personnesDuGroupe) => new { Sexe = sexe, Personnes = personnesDuGroupe}
                                );
            Console.WriteLine("\n1. 1.Faire un group by sur le genre (sexe) des personnes présentes dans la liste d'objets Personne()\n");
            foreach (var s in personneVoulus1)
            {
                Console.WriteLine(s.Sexe);
                foreach (var personne in s.Personnes)
                { 
                    Console.WriteLine(personne.Nom + " " + personne.Prenom);
                }
            }

            // 2 //
            var personneVoulus2 = personnes.GroupBy(
                                    personne => personne.Age,
                                    personne => personne,
                                    (age, personnesDuGroupe) => new { Age = age, Personnes = personnesDuGroupe }
                                  )
                                  .OrderBy(personne => personne.Age);
            //from s in personnes
            //select s;
            Console.WriteLine("\n1. 2.Faire un group by sur l'âge des personnes les trier par âge croissant\n");
            foreach (var s in personneVoulus2)
            {
                Console.WriteLine(s.Age);
                foreach (var personne in s.Personnes)
                {
                    Console.WriteLine(personne.Nom + " " + personne.Prenom);
                }
            }

            // 3 //
            var personneVoulus3 = personnes.Where(personne => personne.Age > 18)
                                  .GroupBy(
                                    personne => personne.Prenom,
                                    personne => personne,
                                    (prenom, personnesDuGroupe) => new { prenom = prenom, Personnes = personnesDuGroupe }
                                  )
                                  .OrderByDescending(personne => personne.prenom);
            //from s in personnes
            //select s;
            Console.WriteLine("\n1. 3. Faire un group by sur le prénom des personnes, et afficher les noms de famille par prénom\n");
            foreach (var s in personneVoulus3)
            {
                Console.WriteLine("\nPrénom : " + s.prenom);
                foreach (var personne in s.Personnes)
                {
                    Console.WriteLine(personne.Nom + " " + personne.Prenom + " " + personne.Age);
                }
            }

            // 4 //
            List<int> nombres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 13, 12, 14, 18, 17, 16, 14, 14 };
            var nombresVoulus = nombres.GroupBy(
                                                    nombre => nombre & 1,
                                                    (pairImpair, nombreAffiche) => new { pairImpair = pairImpair, Nombres = nombreAffiche }
                                               );
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine("\n"+n.pairImpair);
                foreach (var nombre in n.Nombres)
                {
                    Console.WriteLine(nombre);
                }
            }

            // 5 //
            var personneVoulus5 = personnes.GroupBy(
                                    personne => personne.Nom[0],
                                    personne => personne,
                                    (nom, personnesDuGroupe) => new { Nom = nom, Personnes = personnesDuGroupe }
                                  )
                                  .OrderBy(personne => personne.Nom);
            //from s in personnes
            //select s;
            Console.WriteLine("\n1. 5. Grouper les individus par la première lettre de leur nom et faire un tri croissant sur l'attribut Nom de la classe Personne\n");
            foreach (var s in personneVoulus5)
            {
                Console.WriteLine("\n1er lettre nom : " + s.Nom);
                foreach (var personne in s.Personnes)
                {
                    Console.WriteLine(personne.Nom + " " + personne.Prenom + " " + personne.Age);
                }
            }
            */

            //Exercice7
            List<Chien> chiens = new List<Chien>()
            {
                new Chien("Gnocci", "Gnoc Gnoc", "Labrador", "Sable", "M", 1, 20),
                new Chien("Vagabond", "Gros Loup", "Labrador", "Noir", "M", 8, 25),
                new Chien("Milou", "Milos", "Labrador", "Sable", "M", 10, 24),
                new Chien("Sirène", "Sissy", "Labrador", "Sable","F", 4, 19),
                new Chien("Félicia", "Felicci", "Labrador", "Sable", "F", 6, 20),
                new Chien("Kratos", "Mon tueur", "Chihuahua", "Fauve", "M", 1, 2),
                new Chien("Jack", "Jaja", "Chihuahua", "Fauve", "M", 1, 2),
                new Chien("Mojave", "Mojojo", "Chihuahua", "Fauve", "M", 1, 2),
                new Chien("Hercule", "Herc", "Chihuahua", "Beige", "M", 35, 2),
                new Chien("Médusa", "Med", "Terre-Neuve", "Noire", "F", 6, 40),
                new Chien("Mélusine", "Mel", "Terre-Neuve", "Noire", "F", 7, 41),
                new Chien("Venus", "Violette", "Terre-Neuve", "Noire", "F", 8, 38),
                new Chien("Letto", "Lele", "Berger Australien", "Bleu Merle", "M", 3, 30),
                new Chien("Cabron", "Dum dum", "Berger Australien", "Bleu Merle", "M", 9, 31),
                new Chien("Banzaï", "Zaïzaï", "Berger Australien", "Noir et blanc", "M", 1, 28 ),
                new Chien("Haricot", "Harry", "Berger Australien", "Noir et blanc", "M", 2, 27),
                new Chien("Gédéon", "Gégé", "Berger Allemand", "Noir et feu", "M", 9, 31),
                new Chien("Bella", "Belbel", "Berger Allemand", "Noir et feu", "F", 5, 28),
                new Chien("Oui-oui", "oui", "Berger Allemand", "Sable", "M", 7, 35),
                new Chien("Pataud", "Patoche", "Carlin", "Sable", "M", 16, 8),
                new Chien("Killer", "Kiki", "Carlin", "Sable", "M", 10, 8),
                new Chien("Frank", "Colonel", "Carlin", "Noir", "M", 9, 9)
            };

            // 1 //
            var chiensVoulus1 = chiens
                                .GroupBy(c => new { c.Race, c.Couleur })
                                .OrderBy(g => g.Key.Race)
                                .ThenBy(g => g.Key.Couleur);

            Console.WriteLine("\n1. Faire un group by multiple sur la race et la couleur et trier par ordre croissant la race, puis la couleur\n");
            foreach (var groupe in chiensVoulus1)
            {
                Console.WriteLine($"Race : {groupe.Key.Race} | Couleur : {groupe.Key.Couleur}");

                foreach (var chien in groupe)
                {
                    Console.WriteLine($"  {chien.Nom}");
                }
            }

            // 2 //
            var chiensVoulus2 = chiens
                                .GroupBy(c => new { c.Race, c.Genre })
                                .OrderBy(g => g.Key.Genre);

            Console.WriteLine("\n2. Faire un group by multiple sur la couleur et le sexe et trier par ordre croissant sur le sexe\n");
            foreach (var groupe in chiensVoulus2)
            {
                Console.WriteLine($"Race : {groupe.Key.Race} | Sexe : {groupe.Key.Genre}");

                foreach (var chien in groupe)
                {
                    Console.WriteLine($"  {chien.Nom}");
                }
            }

            // 3 //
            var chiensVoulus3 = chiens
                                .Where(c => (c.Age >=2 && c.Age <=15) && !c.Surnom.Contains(" "))
                                .GroupBy(c => new { c.Genre, c.Age, c.Couleur })
                                .OrderBy(g => g.Key.Genre)
                                .ThenByDescending(g => g.Key.Genre)
                                .ThenByDescending(g => g.Key.Age)
                                .ThenByDescending(g => g.Key.Couleur);

            Console.WriteLine("\n3. Faire un group by par sexe, age, couleur\n");
            foreach (var groupe in chiensVoulus3)
            {
                Console.WriteLine($"Sexe : {groupe.Key.Genre} | Age : {groupe.Key.Age} | Couleur : {groupe.Key.Couleur}");

                foreach (var chien in groupe)
                {
                    Console.WriteLine($"  {chien.Nom}");
                }
            }
        }

        class GroupeIngenieur : IEnumerable<object>
        {
            public string[] Groupe;
            public GroupeIngenieur(string[] groupe)
            {
                Groupe = groupe;
            }

            public IEnumerator<object> GetEnumerator()
            {
                foreach(var s in Groupe)
                    yield return s;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
