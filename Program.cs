using System;
//Lasted Updated 8/10/2020. Jonathan S. 
//A simple binary tree maze. 
namespace Testing_Grid
{
    class Program
    {

        static void Main(string[] args)
        {
                const int maxY = 100;
                const int maxX = 100;
                const int min = 10;
                int colSize = -1;
                int rowSize = -1;

                //Ask user for grid size. Only accept valid sizes.
                do {
                    Console.WriteLine("Enter a height for the grid (10 - 100).");
                    colSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a width for the grid (10 - 100).");
                    rowSize = int.Parse(Console.ReadLine());
                    } while (colSize < min || rowSize < min || colSize > maxX || rowSize > maxY);

            string ans = "";
            do
            {
                Console.WriteLine("\n:::Binary Tree Maze:::");
                var binary = new BinaryTreeMaze(colSize, rowSize);
                binary.InitializeGrid();
                binary.RunMaze();
                binary.DisplayGrid();
                Console.WriteLine("\n\n\n");

                Console.WriteLine(":::Sidewinder Maze:::");
                var sidewinder = new SidewinderMaze(colSize, rowSize);
                sidewinder.InitializeGrid();
                sidewinder.RunMaze();
                sidewinder.DisplayGrid();
                Console.ReadLine();
            } while (ans != "exit");
        }

    }

}
