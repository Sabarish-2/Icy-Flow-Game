# Icy Flow Game

> Developed as the final project for the CS50x course by Harvard.

#### Video Demo:  [Icy Flow Game - Youtube](https://youtu.be/Vu_xTYIfh-I?si=Wwo32r6HDzhYE2cO)
**Created by:** Sabarish Hari Iyer  
**Location:** Chennai, India  
**Project Completion Date:** 30/12/2024  
**Production Build - Unity Project:** [Download Project](https://drive.google.com/file/d/1-3y6Ip7FqW9NjBLu4-JDA5hSSYzWRClJ/view?usp=drive_link)  
**Game Build:** [Download Game](https://drive.google.com/file/d/1-68vPcPWSAutAEM33d-5EIqTA1cR5lEm/view?usp=drive_link)  
**GitHub Repository:** [Source Code](https://github.com/Sabarish-2/Icy-Flow-Game)  


## Installation and Setup  

### To Play Game
1. Download the Game build directly from the provided link above.  
2. Extract the files from the downloaded archive.  
3. Locate and run the `Icy.exe` executable file to start the game.  
4. Enjoy the endless runner adventure!  

### To Check Unity Project
1. Clone the repository from the GitHub link or download the Production Build from link provided above.  
2. Open the project in Unity (recommended version: Unity 6 or later).  
3. Check out my game with all the core details.  
4. If you feel like it, modify the code and change the game mechanics as per your choice.  

---

### Description:
Icy Flow Game is a 2D endless runner game. It has a goal of getting a big score, which introduces competitiveness. It was created using Unity 6. This game offers minimalistic graphics with a blue themed design. The objective is to control an ice block, navigating through obstacles while collecting water and avoiding fire. The difficulty of the game increases progressively as speed of approaching water and fire increases with time. With vertical controls, players can only move up or down to survive in this endless adventure, with a twist of a slippery approach while moving to give a feeling of ice.  

Upon opening, you will be greeted with the Main Menu which will have the 3 buttons: Play, How to Play and Quit, which serves the same purpose. It was a lot easier here to just create a canvas and create 3 buttons, out of which one (How to Play) just reuses the same canvas with switching between text and buttons to be shown. Up until here, almost everything was done without coding, just with the Unity inbuilt functions. But, when we enter Play, the game switches between scenes and goes to GameScene, where the game starts to play. From here on everything was mostly coding in C# for unity. Except for graphics, which I wasn't interested in, so just used the default GameObjects and just changing colors to make it look good and different. This game provides an infinite gameplay experience with the help of a spawner which uses a code to spawn other objects using prefabs that I created. Which also increases the difficulty with time, up to a certain extent and caps it there to make it playable infinitely. The random spawner makes it completely unpredictable for the player, even after playing it a lot of times. It has a simple control for ice to move vertically, since horizontal movement is automatically calculated based on time. I achieved this with Unity's built-in InputSystem which helps us get the key presses on the keyboard in our code. You can use W / S to move Up / Down as well as arrow keys (Up / Down) respectively. This makes this game easy to play and fun for anyone. The How to Play section in main menu provides these details. It also includes the details about collecting water for health or bonus score and fire to be avoided with a pictorial representation of what to expect as water and fire since I am not a good designer. I created 2 PreFabs - Water and Fire with code accordingly. The health of the Ice starts with 3 and increases if water is collected. To avoid stacking infinite health, it is capped at 5 and the player will get bonus points added to the score. Collecting Fire reduces the health by 1. All of these are handled by a game manager which contains the code for them. If health reaches 0, the Game Over screen is shown from where we can restart or quit the game or go back to menu. The Game Over screen also displays the score obtained by the player. I also created a Pause screen to stop the game at any moment and go to menu or quit the game. Here I used the similar functionality of creating a single canvas and handle both Pause and Game Over. But here the canvas was much more difficult, since I needed for the score and health to be shown in the same game screen as the game played. Figured it out later, but still kind of a mess, which I think unity should make a little easier, at least for beginners.

Icy Flow Game, developed using Unity 2D, has its coding done in C#. It gave the opportunity for me to learn a new language and learn a whole mixture of syntax. I used the Microsoft Visual Studio for coding which was of a great help for me to learn the syntax and know if there was an error. Especially, the fact that if I miss an error and go to unity to check my build, it shows the same error there as well! Another benefit of using drag-and-drop feature for public or SerializedField variables made it feel like I was coding inside of Unity.

---
