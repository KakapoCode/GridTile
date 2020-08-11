# GridTile
8/10/2020. Jonathan S.

Display a simple Binary Tree Maze and Sidewinder maze in the console. Simplifying the project from earlier versions. I plan on doing the more complete, non-console version, with multiple types of Mazes, at a later date. 

The Grid class handles creation of the Tile objects, and the displaying of the Grid. The Mazes are handled through inheriting from the Grid class. 

The Tiles class handles setting the Location of relevant tile boundaries (In our version, the Southmost and Eastmost tiles). 

TODO: Refactor. If possible, find a way to better encapsulate Grid and the inherited Mazes. Try to do away with using protected fields, and instead use private fields, if at all possible. What kind of design pattern would be a good fit for something small like this? 


 
