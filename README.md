# GridTile
A simple project, relearning C#, to build a grid on the console. Will be expanded upon in a later project.

1.) The enum Location is created to give an easy understanding of where each tile is located.

  a.)This location data gives us an easy way to target common location groups. E.G., we can easily change the top/bottom/side/middle units character.
  
2.) The Tile class currently supports several public static methods for altering grid size. This behavior should be stripped out, leaving better encapsulation (see down below)

3.) At a later date, I need to somehow allow manipulation of the tiles themselves, if the program is to be expanded into procedural maze generation. 

8/3/2020

Things to do better:

1.) Strip some of the functionality out of the tiles class, and program class, and add it to a new class called Grid.

  a.)The Grid class serves as a sort of gameboard. It would be in charge of managing all aspects of the grid. This would include:
  
    i.) The max and minimum sizes of the grid.
    
    ii.) The data for the array of tiles that compose the grid. 
    
    iii.) Methods for allowing the user to alter grid components (such as size, and later on, to run different maze algorithms). 
