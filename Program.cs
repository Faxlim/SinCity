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
                int x = random.Next(1, 99);
                int y = random.Next(1, 24);
                string name = namnLista[random.Next(namnLista.Length)];
                string appearance = "C";
                people.Add(new Citizen(name, appearance, x, y));
                Console.Write(appearance);

               
                
                
            }
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(1, 99);
                int y = random.Next(1, 24);
                string name = namnLista[random.Next(namnLista.Length)];
                people.Add(new Thief(name, "T", x, y));

            }
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(1, 99);
                int y = random.Next(1, 24);
                string name = namnLista[random.Next(namnLista.Length)];
                people.Add(new Police(name, "P", x, y));

            }
            City.BoardCity(25, 100);

        }
    }
}







            //foreach (Person person in people)
            //{
            //    person.X = random.Next(1, 99);
            //    person.Y = random.Next(1, 24);
            //}

            //foreach(Person person in people) 
            //{
            //    //person.X = random.Next(1, 99);
            //    //person.Y = random.Next(1, 24);

            //    if (person is Thief)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
                    
            //    }
            //    else if (person is Police)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;

            //    }
            //    else if (person is Citizen)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    Console.WriteLine(person.Appearance);
            //    Console.ResetColor();
            //}






