// See https://aka.ms/new-console-template for more information

using CyclicRotation;

var testData = new int[] { 1, 2, 3, 4 };
var result = CyclicRotator.Rotate(testData, 4);
Console.WriteLine(string.Join(',', result));