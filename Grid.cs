using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    class Grid
    {
        protected readonly int ColSize;
        protected readonly int RowSize;
        protected string Top;
        protected readonly Tile[,] Tiles;
        protected readonly Random rand = new Random();

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
