# GridTile
A simple project to relearn C#. Display a grid in the console. Eventually, should be expanded to include procedural maze generation algorithms (at the very least, a binary search maze and sidewinder mazes). 

1.) The enum Location is created to give an easy understanding of where each tile is located.

  a.)This location data gives us an easy way to target common location groups. E.G., we can easily change the top/bottom/side/middle units character.

2.) The Grid class is in charge of managing the grid, displaying grid information, and holding the tiles. 

3.) The Tile class provides methods for a given Tile to determine it's symbol (character) value (based on its location in the Grid). The 'walls' of the grid should be distinguishable from the inner portions of the grid. 

Todo:

1 A.) Basic binary maze algorithm. 

1.B) Allow for methods for each tile to update its symbol to the appropriate type, given what the Maze algorithm calls for. 

1.C) In this same vein, we may need a property in Tile to let us know what the Tile is set to. Is it blocked (a wall), or open (empty)? 

Concerns:

1.) If we keep expanding to include more and more maze algorithms, how do we avoid having the Grid class become enormous? 

Perhaps we can include a new Maze class. That being said, how do we give this Maze class access to the Tile objects which will ultimately reside in the Grid class? By opening it public, we reduce encapsulation. 

2.) Would it be better, instead, to have the Tile objects reside in the Maze class? 

Perhaps the Maze class manages the grid, and we utilize a new class to handle the 'UI' so to speak. This new UI class could handle the user's input, and the states of the program. It could allow for the user to select a new maze type from a menu, to exit the program, and to display the grid. The actual displaying of grid information would be done by the Maze class, however. This may allow us to increase encapsulation to some degree: instead of both the Grid and Maze classes needing the Tile[x,y] array, only the Maze class will need it. 

The question, next, is do we use inheritance/polymorphism for the various maze types? 


Last Updated 8/4/2020


 
