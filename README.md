# StarDome
## The files presented here show the logic behind production of the 2D platformer "StarDome":-

* The [**CamFollow.cs script**](CamFollow.cs) acts as a over-the-shoulder third-person camera for the player thus letting them view the dome through just their shoulders but as if they are in control of their character.
* The [**DropdownValue.cs script**](DropdownValue.cs) lets the painter choose a word & an attribute to "draw" over the whole dome.
* The [**ExitScreen.cs script**](ExitScreen.cs)allows the transition to a next stage of the game.
* Te [**FadeIn.cs script**](FadeIn.cs) creates a smooth fade-in animation when the painter is done choosing the word and attribute.
* The [**GameScreen.cs script**](GameScreen.cs) is responsible for creating an on-click transition to the actual game scene.
* The [**MenuScreen.cs script**](MenuScreen.cs) is responsible for letting the player transition from the menu scene to the words selection scene.
* Te [**OnCollision.cs script**](OnCollision.cs) creates an illusion that the "dust particles" that are being thrown from the player are sticking to the dome around them.
* The [**PlayScreen.cs script**](PlayScreen.cs) is responsible for creating an on-click transition to the next part of the game.
* The [**ScriptableString.cs script**](ScriptableString.cs) creates a static variable which can be used in any form to hold data throughout the different scenes and stages of the game (Holds the "word" value).
* The [**ScriptableString1.cs script**](ScriptableString1.cs) is the sister script for the previous mentioned script (Holds the "attribute" value).
* The [**WordChecker.cs script**](WordChecker.cs) is responsible for creating the overall system of checking if the guesser has guessed the word and attribute correctly (this is done by checking the values of ScriptableString1 & 2 to the string of typed text from the guesser).
### Additionally, there are 2 Videoclips which will give you a run-through of what to expect in the game and the internal sections of each script.
Run-Through             |  Code-Explaination
:-------------------------:|:-------------------------:
[![](http://img.youtube.com/vi/_fxo8h80w28/0.jpg)](http://www.youtube.com/watch?v=_fxo8h80w28 "Stardome - A 3D Dome Painting Experience!!") | [![](http://img.youtube.com/vi/7ikp7RgcbZM/0.jpg)](http://www.youtube.com/watch?v=7ikp7RgcbZM "StarDome - Code Explaination")
