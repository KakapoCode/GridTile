using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    enum Location
    {
        SOUTH,
        EAST,
        MID
    }

    class Tile
    {
        public Location Loc { get; private set; }
        public string Symbol { get; set; }
        private static int ColSize = 5;
        private static int RowSize = 5;

        public Tile(int x, int y)
        {
            Loc = Location.MID; //Default to Mid. Relevant boundary tiles will be changed with SetLoc
            SetLoc(x, y);
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


        //Set the location of the tile if it is relevant.
        private void SetLoc(int colLoc, int rowLoc)
        {
            //South tile.

            if (colLoc == ColSize)
                Loc = Location.SOUTH;

            //east tile
            if (rowLoc == RowSize)
                Loc = Location.EAST;
        }
    }
}