﻿//A small frog wants to get to the other side of the road.
//The frog is currently located at position X and wants to get to a position greater than or equal to Y.
//The small frog always jumps a fixed distance, D.

using FrogJmp;

var numberOfJumps = FrogJump.Calculate(10, 85, 30);
Console.WriteLine($"Number of jumps is {numberOfJumps}!");