using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    class Grid
    {
        private readonly int ColSize;
        private readonly int RowSize;
        private string Top;
        private readonly Tile[,] Tiles;
        private readonly Random rand = new Random();

        public Grid(int colSize, int rowSize)
        {
            Tile.SetSize(colSize, rowSize);
            Tiles = new Tile[colSize, rowSize];
            ColSize = colSize;
            RowSize = rowSize;

        }
        public void InitializeGrid()
        {
            for (int i = 0; i < ColSize; i++)
                for (int j = 0; j < RowSize; j++)
                    Tiles[i, j] = new Tile(i, j);

            //Set top boundary size.
            for (int i = 0; i < RowSize + 1; i++)
                Top += "--";
        }

        public void BinaryTreeMaze()
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
                    if (dir == 0 && Tiles[i,j].Loc == Location.MID)
                        Tiles[i, j].Symbol = " |";
                    if (dir == 1 && Tiles[i, j].Loc == Location.MID)
                        Tiles[i, j].Symbol = "__";
                    dir = rand.Next(0, 2);
                }
        }

        public void DisplayGrid()
        {
            Console.WriteLine(Top);
            for (int x = 0; x < ColSize; x++)
            {
                Console.Write("|");
                for (int y = 0; y < RowSize; y++)
                {
                    Tiles[x, y].ReadSymbol();
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(Top);
        }
    }
}
