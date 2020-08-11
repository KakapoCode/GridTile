using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    class BinaryTreeMaze : Grid
    {
        public BinaryTreeMaze(int colSize, int rowSize) : base(colSize, rowSize)
        {

        }
        public void RunMaze()
        {
            //Random between 0 and 1. 0 = south, 1 = east;
            int dir = rand.Next(0, 2);
            //Iterate from North to South, and West to East.
            //If we're at a NORTH tile, we cannot go further north. Set empty space.
            //Likewise for an EAST tile.
            for (int i = 0; i < ColSize; i++)
                for (int j = 0; j < RowSize; j++)
                {
                    if (Tiles[i, j].Loc == Location.EAST)
                        Tiles[i, j].Symbol = "  ";
                    if (Tiles[i, j].Loc == Location.SOUTH)
                        Tiles[i, j].Symbol = "  ";
                    if (dir == 0 && Tiles[i, j].Loc == Location.MID)
                        Tiles[i, j].Symbol = " |";
                    if (dir == 1 && Tiles[i, j].Loc == Location.MID)
                        Tiles[i, j].Symbol = "__";
                    dir = rand.Next(0, 2);
                }
        }
    }
}
