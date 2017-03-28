# Ringo
>The rounded brother of Qubi

## Ringo in a nutshell
The player controls a creature which consists of rings formed at different stages of the game by attracting and capturing smaller particles or other creatures. The formation of each ring requires a number of particles of the matching kind to be captured. Players try to form a set of predefined ring patterns in a set of challenges. The creative game mode is all about experimentation, combining different patterns to unlock the special powers of Ringo, and coming up with a unique pattern to share with your friends.

## Game mechanics
- Good breaths (as identified by the recogniser) lead to expansion of the "fringe" which is the area of Ringo that attracts other particles. The expanded area is maintained for a set period of time or until the next breath. Bad breaths or lack of lead to shrinking the attraction area completely. In this state Ringo just wanders around "waiting" for the player to continue - there is no penalty for breaking the pace since the session could be interrupted for a variety of reasons.

- Rich game experience is achieved by relying on random movement of the player and all other game objects. Of course the movement doesn't have to be completely random - algorithms could be developed to guide the gameplay into certain scenarios. In addition the movement parameters could be exposed for the player to choose as a configuration step before the session. Some example parameters could be smooth vs sharp turns, exploring new areas vs sticking to well-known territory, chasing desired particles vs avoiding threats.

- Building rings should be a predictable process at least in the beginning - there is a clear progression, the player can see both the short term goal - forming the next ring (by visual signals in gameplay) and the long-term goals - the final pattern they are trying to achieve in this part of the story.

## Implementation details
- The core mechanic of attracting and capturing particles is achieved by using a point effector and a circular edge collider to form the fringe. There is a lot to play with in terms of scale - the inner rings that contain particles could be transformed into solid sprites, multiple edge colliders could be used if better separation is needed when expansion happens.

- Expansion of the attraction area could be visualised with a dynamic particle system around the fringe.

## What do we do with the button?
The Fizzyo button is not an essential part of the gameplay. It could be used for adding new skills to Ringo - such as reversing the action of the attractor when the button is pressed - to avoid harmful particles, or switching between pre-defined movement profiles in-game, or for rapidly accelerating Ringo in the current movement direction to capture that extra special particle which is getting away.

## Plans for the creative mode
Being able to play and interact in a world with all the other players (and many AI players) is the main goal of playing the game. The intial challenges / story mode are meant to make the player comfortable with playing the game during their sessions. Experienced players will most likely prefer joining the open world and playing with their friends.
