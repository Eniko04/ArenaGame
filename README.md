ArenaGame is a console-based combat simulation game where players pit various heroes against each other in battles to the death. The game engine simulates these fights, showcasing each hero's unique abilities and weaponry, with real-time battle progress notifications. The goal is to determine the champion hero through a series of intense battles.

Game Engine:

Class: GameEngine
Responsibilities: Manages the overall game logic, including initiating battles, handling turn-based combat, and determining the winner. It also provides notifications during the fight.
Key Methods:
Fight(): Orchestrates the fight between two heroes, alternating attacks until one hero is defeated.
Notification System: Uses the NotificationArgs class and GameNotifications delegate to provide updates about each attack and its impact.
