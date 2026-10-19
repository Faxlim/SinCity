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
            width = 100;
            height = 25;
        }
        public static void BoardCity(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if(i <= width || i >= 0 || j <= height || j >= 0)
                    {
                        Console.Write("X");
                        

                    }
                }
                Console.WriteLine();
            }
        }
    }
}

