# GDIM33 Vertical Slice
## Milestone 1 Devlog
1.
I made the player movement a visual scripting graph. There are three main parts to this graph: movement, camera rotation, and extra controls.
Movement is detected with the OnInputSystemEvent Vector2 node; it translates the inputs from the keyboard into x and y coordinates. These coordinates are used to translate the player's x and z coordinates.
I intentionally excluded a jumping mechanic as that would introduce challenges that would make gameplay much harder to balance and control. In terms of the next part, camera rotation, I used the same node but with the 'look'
option. I also added mouse sensitivity, which is multiplied by the outputs from the node to rotate the camera along the x and y axes. Finally, the extra controls include sneaking and sprinting. Both are achieved by having a variable that changes
the current move speed. When the player presses and holds on a specific key (Z for sneaking and lshift for sprinting), the move speed is multiplied or divided by a set value. They also toggle respective booleans that affect the robot's detection range.

2.
Updated breakdown with state machine: 
https://docs.google.com/drawings/d/1gc5vngVaGjAX02m7_Y1whSA0TJEfXJuqW6R97aFko5Y/edit
I added a state machine to the robot. This state machine has three states: Unloaded, Searching and Chasing. 
For the breakdown, I added the 3 states that the state machine can be in at any given time.
In the unloaded state, it is disabled. As for now, it exists as the robot's default state-this is intended to be the state it is in whenever a round is not actively occurring.
In the searching state, it first sets the speed of the robot (this matters when it is transitioning back from the chasing state), and then chooses a random place to move towards.
Afterwards, it checks whether it is within chasing distance of the player. This distance is dynamic; depending on whether the player is sneaking or not, it can increase or decrease.
This is tracked via a boolean that's updated by the player's script machine. If the robot is close enough, then it'll transition to the chase state. This is the robot's default state when it is 
enabled.
In the chase state, it increases its movement speed and locks onto the player's position. In this state, the robot has a secondary distance gauge; if it is touching the player, a counter begins.
When this counter reaches a certain threshold (5 seconds) it triggers a boolean which makes the player lose the game, and transitions the robot back to the unloaded state.
This counter is only reset when the robot leaves the chasing state-how the robot leaves is essentially the opposite of the way the robot enters the chase state. 

## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!

Unity's Toon Shader