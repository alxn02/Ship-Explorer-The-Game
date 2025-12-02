1. Functional Requirements:
Here are the main features I added:
Fuel system that decreases when the ship moves

Collectibles the ship can pick up (fuel cans, stars, shield)

Enemy system with basic AI movement

Score system that updates when the player collects items

Basic collision interactions between the ship, enemies, and collectibles

3. Class List & Descriptions

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

5. UML Diagram
My UML diagram shows the main classes (Ship, Fuel, Collectible, Enemy, ScoreSystem) and how they relate through inheritance and composition.

6. Weekly Progress
Week 1:
Defined project scope

Wrote functional requirements

Created class list and design

Made UML diagram

Planned features and data structures

Week 2 Progress Report — Alan’s Team
What I Completed This Week:

Started implementing all main classes for the project (Ship, Fuel, Collectible, Enemy, ScoreSystem).

Added basic movement, collisions, and simple interactions (collecting items, losing fuel, etc).

Updated my UML diagram to reflect the new classes and relationships.

Wrote initial plans for unit tests for each class and method.
     
Began organizing scripts and preparing for the demo video.

Challenges:
Making sure the class relationships made sense with OOP concepts (inheritance, polymorphism).

Planning which data structures to use for enemies, collectibles, and fuel types.

Getting the collisions and interactions to work consistently.

How I Resolved / Plan to Resolve

Reorganized class responsibilities and cleaned up the UML to make each class’s role clearer.

Decided on data structures (List for enemies, List for collectibles, Dictionary for fuel types, Stack or Queue for history systems).

Will continue adjusting collisions as more mechanics are added.

What’s Next (Week 3 Plan):
Finish enemy AI behaviors (Patrol + Chaser).

Add more collectible types and refine item effects.

Implement UI for score, fuel, and status indicators.

Finish unit tests for all implemented methods.

Record and finalize the demo video for the class.

How to Run the Project:

Open the Unity project.

Load the MainScene.

Press Play to test movement, collectibles, and fuel mechanics.
