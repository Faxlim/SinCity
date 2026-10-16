using System.Runtime.CompilerServices;

namespace SinCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namnLista = { "Andersson",
                "Johansson",
                "Karlsson",
                "Nilsson",
            };
            Random rnd = new Random();

            List<string> city = new List<string>(namnLista);

            foreach (string namn in namnLista)
            {
                Console.WriteLine(namn);
            }

        }
    }
}

                









//"Eriksson",
//                "Larsson      
//                "Olsson",
//                "Persson",
//                "Svensson",
//                "Gustafsson",
//                "Lindberg",
//                "Lundgren",
//                "Bergström",
//                "Holm",
//                "Sandberg",
//                "Björk",
//                "Dahl",
//                "Berg",
//                "Nyström",
//                "Håkansson",
//                "Ström",
//                "Lindqvist",
//                "Mattsson",
//                "Fredriksson",
//                "Wallin",
//                "Ekström",
//                "Axelsson",
//                "Berglund",
//                "Samuelsson",
//                "Löfgren",
//                "Hellström",
//                "Blomqvist",
//                "Norberg",
//                "Åkesson",
//                "Sahlberg",
//                "Edlund",
//                "Boström",
//                "Isaksson",
//                "Marklund",
//                "Sjöberg"