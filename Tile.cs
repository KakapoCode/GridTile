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
        private static int ColSize = 5;
        private static int RowSize = 5;

        public Tile(int x, int y)
        {
            Loc = Location.Error; //Default to Location.Error, just in case SetLoc somehow fails.
            SetLoc(x, y);
            SetSymbol();
        }

        static public void SetSize(int col, int row)
        {
            ColSize = col - 1;
            RowSize = row - 1;
        }
        public void ReadSymbol()
        {
            Console.Write(Symbol);
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
        private void SetLoc(int colLoc, int rowLoc)
        {
            //Top Left, Top Middle, and Top Right
            if (colLoc == 0 && rowLoc == 0)
            {
                Loc = Location.TopLeft;
            }
            if (colLoc == 0 && rowLoc > 0 && rowLoc < RowSize)
            {
                Loc = Location.Top;
            }
            if (colLoc == 0 && rowLoc == RowSize)
            {
                Loc = Location.TopRight;
            }

            //Middle Left, Middle, and Middle Right
            if (colLoc > 0 && colLoc < ColSize && rowLoc == 0)
            {
                Loc = Location.Left;
            }
            if (colLoc > 0 && colLoc < ColSize && rowLoc > 0 && rowLoc < RowSize)
            {
                Loc = Location.Mid;
            }
            if (colLoc > 0 && colLoc < ColSize && rowLoc == RowSize)
            {
                Loc = Location.Right;
            }

            //Bottom Left, Bottom, and Bottom Right
            if (colLoc == ColSize && rowLoc == 0)
            {
                Loc = Location.BottomLeft;
            }
            if (colLoc == ColSize && rowLoc > 0 && rowLoc < RowSize)
            {
                Loc = Location.Bottom;
            }
            if (colLoc == ColSize && rowLoc == RowSize)
            {
                Loc = Location.BottomRight;
            }
        }
    }
}
