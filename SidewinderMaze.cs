using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Grid
{
    class SidewinderMaze : Grid
    {
        public SidewinderMaze(int colSize, int rowSize) : base(colSize, rowSize)
        {
        }
        public void RunMaze()
        {
            int dir = rand.Next(0, 2);
            int runSize = 0;
            Tile[] run = new Tile[20];

            for (int i = 0; i < ColSize; i++)
                for (int j = 0; j < RowSize; j++)
                {
                    Tiles[i, j].Symbol = "__";
                    run[runSize] = Tiles[i, j];
                    dir = rand.Next(0, 2);
                    //Close out the run if dir = 0 and we have a run.

                    //If dir = 1, but we're at a far south or east wall, close the run.
                    if (Tiles[i, j].Loc == Location.EAST || Tiles[i, j].Loc == Location.SOUTH)
                    {
                        dir = rand.Next(0, runSize + 1);
                        run[dir].Symbol = "  ";
                        Array.Clear(run, 0, runSize);
                        runSize = 0;
                    }

                    else if (dir == 0)
                    {
                        dir = rand.Next(0, runSize + 1);
                        run[dir].Symbol = " |";
                        Array.Clear(run, 0, runSize);
                        runSize = 0;
                    }

                    else if (dir == 1)
                    {
                        runSize++;
                    }

                }
        }
    }
}
