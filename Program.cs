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
                "Eriksson",
                "Larsson",      
                "Olsson",
                "Persson",
                "Svensson",
                "Gustafsson",
                "Lindberg",
                "Lundgren",
                "Bergström",
                "Holm",
                "Sandberg",
                "Björk",
                "Dahl",
                "Berg",
                "Nyström",
                "Håkansson",
                "Ström",
                "Lindqvist",
                "Mattsson",
                "Fredriksson",
                "Wallin",
                "Ekström",
                "Axelsson",
                "Berglund",
                "Samuelsson",
                "Löfgren",
                "Hellström",
                "Blomqvist",
                "Norberg",
                "Åkesson",
                "Sahlberg",
                "Edlund",
                "Boström",
                "Isaksson",
                "Marklund",
                "Sjöberg"
            };
            Random random = new Random();

            List<Person> people = new List<Person>();
            
            for (int i = 0; i < 20; i++)
            {
                string name = namnLista[random.Next(namnLista.Length)];
                people.Add(new Citizen(name, "C"));
                
            }
            for (int i = 0; i < 10; i++)
            {
                string name = namnLista[random.Next(namnLista.Length)];
                people.Add(new Thief(name, "T"));

            }
            for (int i = 0; i < 5; i++)
            {
                string name = namnLista[random.Next(namnLista.Length)];
                people.Add(new Police(name, "P"));

            }
            City.BoardCity(25, 100);

            foreach(Person person in people) 
            {
                if(person is Thief)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                }
                else if (person is Police)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                else if (person is Citizen)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(person.Appearance);
                Console.ResetColor();
            }

        }
    }
}













