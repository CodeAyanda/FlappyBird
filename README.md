# FlappyBird

This is a recreation of the famous game Flappy Bird or in my case Flappy Dot?
Had some fun creating this game using object oriented programming.
The game has a Bird object in the Bird.cs class. Pipes in the Pipes.cs class and the main class is Form1.cs.
Instead of creating my own collision detection I experimented with the C# function Rectangle.IntersectsWith(Rectangle) to detect whether a rectangle intersects with another rectangle. I found success with this method but I found it buggy at times like if you touch the pipes at the corners it sometimes does not detect it.
I would be better off checking if the bird's x position is less than the pipe's x position and the same thing with the y position, but this can be fixed in future.

Running Code : Download Code Folder, Open FlappyBird folder, Open FlappyBird.csproj (C# project)

Running Game : Download Run Folder, Open FlappyBird.exe

Game Notes : Still need to add score, The game generates 1000 pipes and stores them in an array - would like to dynamically generate pipes as they go off screen.
