﻿// A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

using OddOccurrencesInArray;

var testData = new int[] {9, 3, 9, 3, 9, 7, 9};
var result = OddOccurence.Count(testData);
Console.WriteLine($"Your result is {result}");