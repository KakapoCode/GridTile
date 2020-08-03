using System;

namespace Testing_Grid
{
    class Program
    {

        static void Main(string[] args)
        {
                const int maxY = 100;
                const int maxX = 100;
                const int min = 5;
                int colSize = -1;
                int rowSize = -1;

                //Ask user for grid size. Only accept valid sizes.
                do {
                    Console.WriteLine("Enter a height for the grid (5 - 100).");
                    colSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a width for the grid (5 - 100).");
                    rowSize = int.Parse(Console.ReadLine());
                    } while (colSize < min || rowSize < min || colSize > maxX || rowSize > maxY);

                Tile.SetGridSize(colSize, rowSize);
                Tile[,] tiles = new Tile[colSize, rowSize];

                //Initialize the objects in the grid array. Draw the grid using their symbol. 
                for (int x = 0; x < colSize; x++)
                {
                    for (int y = 0; y < rowSize; y++)
                    {
                        tiles[x, y] = new Tile(x, y);
                        tiles[x, y].ReadSymbol();
                    }
                    Console.WriteLine();
                }
        }

    }
}
