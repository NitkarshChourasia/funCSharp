/*
####  Track the Robot (Part 2)  ####

This robot roams around a 2D grid. It starts at (0, 0) facing North. After each time it moves, the robot rotates 90 degrees clockwise. Given the amount the robot has moved each time, you have to calculate the robot's final position.
To illustrate, if the robot is given the movements int [] { 20, 30, 10, 40 } then it will move:
___
*) 20 steps North, now at (0, 20)
*) 30 steps East, now at (30, 20)
*) 10 steps South. now at (30, 10)
*) 40 steps West, now at (-10, 10)
___

...and will end up at coordinates (-10, 10).


[Examples]

___
TrackRobot(new int[] { 20, 30, 10, 40 }) ➞ [-10, 10]

TrackRobot(new int[] { }) ➞ [0, 0]
// No movement means the robot stays at (0, 0).

TrackRobot(-10, 20, 10) ➞ [20, -20]
// The amount to move can be negative.
_____



[Notes]

___
*) Each movement is an integer (whole number).
*) The return value must be of type int[]
___



[conditions] [logic] [loops] 



-------------------------------------------------------------------
[Resources]


[No Resources]


*/
//Your code should go here:

