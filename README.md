I completed everything from Chapters 7, 8, and 9.

A brief description of what I did:

For Chapter 7, the Player now has a capsule collider and uses physics-based movement for better interactions with walls.

For Chapter 8, there are two additional scenes for winning and losing. The GameMode empty object contains the code for switching scenes. One of the losing conditions is the destruction of the base. Inside the house on the right, there is a pillar that enemies move toward and shoot when the player is not in sight. Once the pillar's health reaches zero, the game switches to the lose scene, which contains a large cube to represent defeat. The win scene contains a large sphere to represent victory.

For Chapter 9, enemies now use a finite state machine to control their behavior and navigation. A NavMesh has also been added to the house floor and extends onto the road outside.