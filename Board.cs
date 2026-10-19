using System;
using System.Collections.Generic;
using System.Text;

namespace SinCity
{
    internal class Board
    {
       
        public int Width { get; set; }
        public int Height { get; set; }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
        }
       
}

    class Prison : Board
    {
        public Prison(int width, int height) : base(width, height)
        {
            
        }
    }

    class PoorHouse : Board
    {
        public PoorHouse(int width, int height) : base(width, height)
        {

        }
    }

    class City : Board
    {
        public City(int width, int height) : base(width, height)
        {
           
        }
        public static void BoardCity(int height1, int width1)
        {
            for (int i = 0; i < height1; i++)
            {
                for(int j = 0; j < width1; j++)
                {
                    if(i == 0 && j == 2)
                    {
                        Console.Write(" SINCITY ");
                        j += 9;
                    }
                    if(i == height1 -1|| i == 0 || j == width1 -1|| j == 0)
                    {
                        Console.Write("█");
                        

                    }
                    
                    
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void InsideCity()
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
            

        }
    }




}

