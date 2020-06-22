# tada
C# code for VR game

C# code files for  a VR game using Occulus Rift, Leap Motion Sensor and a Unity Scene. 
======================================================
Project Development
===================
This project consists of the Oculus Rift and the Leap Motion Sensor. The Oculus Rift is used to provide a Virtual Reality vision of the game environment while the Leap Motion Sensor is utilized to enable interaction between the user and the game environment through the detection of the user’s hand movements. Additionally, Unity was the software used to create the environment, the scripts that run the
game and to connect the leap motion sensor to the oculus rift.

The game utilises two scenes: the Start Scene and the Game Scene.

Start Scene:
The start scene provides an Interactive User Input scenario where the user can virtually click on the button they wish to click on. The buttons are part of the UI Game Objects allowing the user to interact with them and the Leap Input Module is used to allow the Leap motion sensor to detect UI objects and allow the user to interact with them.

Game Scene
The most important assets used in this scene are the 3D spheres as shown in the picture below. They are the game objects that the user’s hand (represented by the index finger’s collider) collides with. To create a more engaging and fun learning environment, 3D cubes were added to resemble building blocks and the material textures were changed to bright patterns and colours.

======================================================
The game is controlled by 6 scripts (scripts included at the end of the report):
ColourManager.cs
- The ColourManager Script has the main function of managing the loop of the game, assigning the colours randomly to the ball, and the score display. The ColourManager accesses each of the balls and their renderers allowing it to change the colour of one random ball to blue.
- The script generates a number randomly between 1 and 3 (inclusively) and changes the material colour of the ball (a game object sphere) and the tag of the object to “touchable”. The tag allows to Attach function to recognise whether or not the user has touched the correct ball.
- The ColourManager has 2 integer counters to monitor when the script should reset and change the ball colours and tags. The numCtr counts the number of times the loop has run and is initialised at 1 whilst the prevCtr counts the (numCtr-1) times the loop has run. The prevCtr counter is incremented first when the loop starts and the numCtr counter is incremented when the “game round” ends and the loop runs when (numCtr > prevCtr).
- The script ensures that the next ball is assigned only once the user’s virtual hand exits the ball. This eliminates the possibility of the user’s hand still being in the ball and hence “in collision” with the ball when a new ball is assigned giving false results.
- Once the player has played the game 10 times (numCtr = 11), the loop stops the score screen is enabled displaying the score for 10 seconds and then returning to the Start Screen.

Attach.cs:
- The Attach script has a integer score counter (scoreCtr) to keep track of the score.
- The Attach script is attached to each of the three balls and it is the script that checks whether or not the user has touched the correct “blue” tagged ball. The script does so by checking whether or not the ball is tagged “touchable” when a collision takes place.
- If the ball with which the collision takes place is tagged “touchable”, the script changes the material colour to green and scoreCtr is incremented. If it is “untagged”, the material colour changes to red to indicate an incorrect answer to the user.
- Once the user’s “hand” exits the ball, the colour of the ball resets to white and the numCtr variable from the ColourManager script is incremented allowing the next game round to start.

dontdestroy.cs
- The dontdestroy script accesses the score from the Attach script and has the DontDestroyOnLoad function to allow to keep the score even when the scene changes.
- The script changes the text of the score and the message. It displays “Well Done!” if the score is greater than or equal to 7. Otherwise, it displays “Good Effort!”. The script also changes the Score and displays “Score: x/10” as x varies.

HelpButton.cs
- The script enables a game object that displays the help message. The Message is displayed for 10 seconds and then returns to the Start Menu screen.

ExitButton.cs
- The script quits the application

StartButton.cs
- The script takes the user to the Game scene titled “Tada! Game Scene” allowing the game to start.
