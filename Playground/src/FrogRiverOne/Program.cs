﻿// A small frog wants to get to the other side of a river.
// The frog is initially located on one bank of the river (position 0) and wants to get to the opposite bank (position X+1).
// Leaves fall from a tree onto the surface of the river.

using FrogRiverOne;

var testData = new int[] {1, 3, 1, 4, 2, 3, 5, 4};
var result = FrogJump.Calculate(5, testData);
Console.WriteLine($"The result is {result}");