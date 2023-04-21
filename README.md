# Game-Paradise
Side project by Danail Danailov.

"Game Paradise" is a collection of 12 retro video games, each with its own unique gameplay. The project is developed as a stand-alone computer application to be installed on a Windows PC. With this project, we hope to give players an enjoyable, and for some, nostalgic gaming experience.

The architecture of Game Paradise  is designed on the principle of modularity. Each game window is built as a separate form within the main application, allowing easy modification and addition of new games. The personal records section is also built as a separate form that interacts with the game windows through a shared database. This approach allows flexibility and scalability of the application.

![Картина1](https://user-images.githubusercontent.com/131172818/233669911-bb34edb9-33a8-44d8-b94a-a8065eb205cf.png)

The main modules of the Game Paradise app include:
o Main Navigation Menu - Provides access to all twelve games, the personal bests section and the game controls form.
o Game windows - Individual windows for each game that contain unique game controls and mechanics.
o Personal Records form - A form that displays the user's personal records for a selected game.
o Game Controls Form - A form that facilitates the user's work with the application by informing him about the controls of each game.
o Database - a local database that stores the user's personal records in a text document.
