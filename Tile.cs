using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    enum Location
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Top,
        Bottom,
        Left,
        Right,
        Mid,
        Error
    }

    class Tile
    {
        private Location Loc;
        private string Symbol;
        private static int Height = 5;
        private static int Width = 5;

        public Tile(int x, int y)
        {
            Loc = Location.Error; //Default to Location.Error, just in case SetLoc somehow fails.
            SetLoc(x, y);
            SetSymbol();
        }

        public void ReadSymbol()
        {
            Console.Write(Symbol);
        }

        //Set our grid size information. Because arrays start at 0, we minus 1. 
        public static void SetGridSize(int height, int width)
        {
            Height = height - 1;
            Width = width - 1;
        }

        //Set the symbol of each tile based on its location. 
        private void SetSymbol()
        {
            if (Loc == Location.TopLeft || Loc == Location.TopRight || Loc == Location.Top)
                Symbol = "^";
            if (Loc == Location.Left || Loc == Location.Right)
                Symbol = "|";
            if (Loc == Location.BottomLeft || Loc == Location.BottomRight || Loc == Location.Bottom)
                Symbol = "v";
            if (Loc == Location.Mid)
                Symbol = "*";
            if (Loc == Location.Error)
                Console.WriteLine("Error: A Tile was not assigned a proper location.");
        }

        //Set the location of the tile, given the index of the 3D array. E.G. tile[0,0] refers to TopLeft of the grid.
        private void SetLoc(int x, int y)
        {
            //Top Left, Top Middle, and Top Right
            if (x == 0 && y == 0)
            {
                Loc = Location.TopLeft;
            }
            if (x == 0 && y > 0 && y < Width)
            {
                Loc = Location.Top;
            }
            if (x == 0 && y == Width)
            {
                Loc = Location.TopRight;
            }

            //Middle Left, Middle, and Middle Right
            if (x > 0 && x < Height && y == 0)
            {
                Loc = Location.Left;
            }
            if (x > 0 && x < Height && y > 0 && y < Width)
            {
                Loc = Location.Mid;
            }
            if (x > 0 && x < Height && y == Width)
            {
                Loc = Location.Right;
            }

            //Bottom Left, Bottom, and Bottom Right
            if (x == Height && y == 0)
            {
                Loc = Location.BottomLeft;
            }
            if (x == Height && y > 0 && y < Width)
            {
                Loc = Location.Bottom;
            }
            if (x == Height && y == Width)
            {
                Loc = Location.BottomRight;
            }
        }
    }
}
