using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    class Grid
    {
        private int ColSize;
        private int RowSize;
        private Tile[,] Tiles;


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
        }

        public void DisplayGrid()
        {
            for (int x = 0; x < ColSize; x++)
            {
                for (int y = 0; y < RowSize; y++)
                {
                    Tiles[x, y].ReadSymbol();
                }
                Console.WriteLine();
            }
        }
    }
}
