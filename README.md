I completed everything from Chapter 7, 8, and 9

For chapter 7, you can see the capsule collider in Player. The player also have physics for movement and better interaction when pushing against the wall

For chapter 8, There is now two more scene for Winning and Losing condition. The GameMode empty object contains the code for changing the scene. One of the losing condition is when the base is destroyed. To implement this, inside the house to the right, there is a pillar that all the enemy will rush toward if player is not in sight. Then it will shoot it. Once the pillar HP drop, the game will switch scene to lose scene which contain a huge cube to symbolize losing. Win screen is symbolikzed by huge sphere.

For chapter 7, the Enemy now have finite state machine for deciding pathing. Also NavMesh is added to the floor of the house and extends outward to the road leading outside.