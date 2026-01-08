namespace ex_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> entiers = new List<int> { 4, 5, 2, 3, 1, 1, 0, 5, 8, 9, 10, 15, 16, 20, 21, 4, 5 };

            //
            var nombresVoulus = from n in entiers
                                where n > 5
                                select n;

            Console.WriteLine("1. Récupérer et afficher tous les nombres supérieurs à 5 \n");
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine(n);
            }

            //
            nombresVoulus = from n in entiers
                            where n >= 15 && n <= 20
                            select n;
            Console.WriteLine("2. Récupérer et afficher les nombres supérieurs ou égaux à 15 et inférieurs à 20\n");
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine(n);
            }

            //
            nombresVoulus = from n in entiers
                            where n > 2 && n % 2 == 0 && n < 20 && n != 8
                            select n;
            Console.WriteLine("3. Récupérer et afficher les nombres supérieurs à 2, qui sont des multiples de 2, inférieurs à 20, différents de 8\n");
            foreach (var n in nombresVoulus)
            {
                Console.WriteLine(n);
            }

            //
            List<string> fruits = new List<string> { "Banane", "Ananas", "Cerise", "Framboise", "Groseilles", "Pomme", "Poire", "Tomate", "Kiwi", "Raisin", "Mangue", "Datte" };
            var fruitsVoulus = from s in fruits
                               where s.Length > 5
                               select s;
            Console.WriteLine("4. Récupérer et afficher tous les fruits dont le nom contient plus de 5 lettres\n");
            foreach (var s in fruitsVoulus)
            {
                Console.WriteLine(s);
            }

            //
            fruitsVoulus = from s in fruits
                           where s[0].ToString() == "P" && s.Length > 4 && s.Contains("o") && !s.Contains("m")
                           select s;
            Console.WriteLine("5. Récupérer et afficher tous les fruits dont le nom commence par \"P\", dont la longueur du nom est supérieure à 4, qui contiennent un \"o\" mais pas de \"m\"\n");
            foreach (var s in fruitsVoulus)
            {
                Console.WriteLine(s);
            }

            //
            fruitsVoulus = from s in fruits
                           orderby s.Length
                           select s;
            Console.WriteLine("6. Trier et afficher les fruits selon leur longueur\n");
            foreach (var s in fruitsVoulus)
            {
                Console.WriteLine(s);
            }

            //
        }
    }
}
