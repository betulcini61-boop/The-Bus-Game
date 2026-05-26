# The-Bus-Game
#Demo:https://youtu.be/bupLnu4VJGQ?si=wqzK5hXyY3FzTrl3
###Description
The Bus Game is a 2D arcade-style game developed in Unity as my final project for Harvard's CS50 course. The idea came from a simple but relatable concept — navigating through heavy traffic, just like the buses we see every day on the busy streets of Istanbul. The goal of the game is straightforward: control your bus, avoid the other cars on the road, and survive as long as possible without crashing.
This project was my first experience building a game completely from scratch. Before starting, I had no prior knowledge of Unity or game development in general. Everything I learned — from setting up scenes and working with GameObjects, to writing C# scripts and managing collisions — came through research, trial and error, and a lot of patience. It was one of the most challenging things I have done, but also one of the most rewarding.
How to Play
The controls are simple and entirely keyboard-based, making the game easy to pick up but harder to master as the traffic gets more intense.
Arrow Keys / W & S — Move the bus up and down between lanes
Shift — Hold to speed up the bus
R — Return to the main screen after a Game Over
Your bus starts in the middle of the road and must navigate through randomly spawning cars coming from different lanes. The road scrolls continuously, giving the feeling that your bus is always moving forward. The longer you survive, the more chaotic the traffic becomes.
Features
Lane-Based Movement
The bus moves vertically between a set of lanes. Its Y position is clamped within defined boundaries so it can never go off the road. This boundary system was implemented through a simple but effective script that reads the bus's current Y position in real time and restricts it to the playable area.
Random Car Spawning
Enemy cars are spawned at random intervals from the right side of the screen and travel across the road at varying speeds. The spawning system uses a dedicated script (ArabaDogmaYerler) that selects random lane positions and timings, ensuring that no two rounds feel exactly the same.
Fuel System
One of the more complex features of the game is the fuel system. The bus has a fuel bar that slowly drains as you play. If your fuel runs out, it's game over — just like running out of gas in real life. To keep going, you need to collect fuel pickups that appear on the road. This system adds an extra layer of strategy: sometimes slowing down or changing lanes is necessary not just to avoid cars, but to grab fuel before it disappears.
Speed Mechanic
By holding Shift, the player can temporarily increase the bus's speed. This is useful for dodging cars quickly but also makes the fuel drain faster, so it needs to be used wisely. The speed and fuel systems work together to create a risk-reward balance at the heart of the gameplay.
Game Over Screen
When the bus collides with another car or runs out of fuel, the game transitions to a Game Over screen. The player is shown a simple message and given the option to press R to return to the main menu and try again. The transition is handled by the GameManager script, which listens for collision and fuel events throughout the game.
Background and Atmosphere
The game features a scrolling Istanbul-inspired cityscape background, complete with buildings, trees, and a blue sky. This gives the game a local identity and makes it feel grounded in a real place. Sound effects and background music are also included to make the experience more immersive and enjoyable.
Technical Details
The game was built entirely in Unity using C#. The project is organized into multiple scripts, each responsible for a specific part of the game:
BusController — Handles player input and bus movement
YolKaydırma — Controls the continuous scrolling of the road to simulate forward movement
GameManager — Manages overall game state and scene transitions
ArabaDogmaYerler — Controls the random spawning of enemy cars on the road
CarDestroy — Handles the destruction of enemy cars once they exit the screen, keeping performance clean
Çarpışma — Detects and handles collision events between the bus and other vehicles
FuelSlide — Manages the fuel bar UI and the fuel drain logic over time
BenzinDogma — Handles fuel pickup spawning on the road
MoneySpawner — Spawns collectible money items on the road for the player to collect
ScoreManager — Tracks and displays the player's score throughout the game
Each script handles one specific responsibility, keeping the codebase clean and easy to manage.
All assets including sprites, sounds, and backgrounds were carefully chosen and arranged to create a cohesive visual style.
