1. Functional Requirements
Here are the main features I added:
Fuel system that decreases when the ship moves
Collectibles the ship can pick up (fuel cans, stars, shield)
Enemy system with basic AI movement
Score system that updates when the player collects items
Basic collision interactions between the ship, enemies, and collectibles

2. Class List & Descriptions

Ship – player movement, fuel usage, interactions
Fuel – handles fuel amount, refilling, and consumption
Collectible (base class) – parent class for items
FuelCanister – adds fuel to the ship
StarCollectible – increases score
ShieldCollectible – (optional) gives protection
Enemy (base class) – simple enemy logic
ScoreSystem – tracks score and updates values
GameManager – handles references and overall game flow

3. Data Structures Used
I used four data structures in this project:
List<Collectible> – storing all collectible objects in the scene
Dictionary<string, float> – different fuel types and their values
Queue<float> – storing recent fuel usage
List<Enemy> – storing and updating enemies

4. UML Diagram

My UML diagram shows the main classes (Ship, Fuel, Collectible, Enemy, ScoreSystem) and how they relate through inheritance and composition.

5. Weekly Progress
Week 1

Defined project scope

Wrote functional requirements

Created class list and design

Made UML diagram

Planned features and data structures

Week 2
Started implementing classes
Wrote basic Ship, Fuel, Collectible, Enemy, and Score scripts
Added collisions and basic interactions
Updated UML diagram
Started writing unit test plans

6. What’s Next
Finish implementing full enemy behaviors
Add more collectibles
Add UI for score and fuel
Finish unit tests

Will make the demo video

7. How to Run
Open the project in Unity.
Load the main scene.
Press Play.
