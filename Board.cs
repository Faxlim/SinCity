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
    }
}

